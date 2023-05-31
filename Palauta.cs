using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kirjasto
{
    public partial class Palauta : Form
    {
        MySqlConnection connection;
        DataTable dtKirjat;

        DateTime paivaTanaan = DateTime.Now;

        public string lainakirjaIdlainausrivi;
        public string palautuskirja;

        Form1 f1 = new Form1();
        public Palauta(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            connection = new MySqlConnection(f1.kirjastoConnString);
        }

        private void Palauta_Load(object sender, EventArgs e)
        {
            HaeTiedot();
        }

        public void HaeTiedot()
        {
            // haetaan lainatut taulusta kirjat (paitsi kirjastosta poistetut kirjat) ja täytetään dataGridViewKirjat
            string kyselyKirjat = "SELECT idlainausrivi AS 'tunnus', idkirjat, knimi AS 'Kirja', tekijaenimi, tekijasnimi, lainauspvm, palautuspvm, idasiakkaat AS 'as_id', enimi AS 'lainaaja_enimi', snimi AS 'lainaaja_snimi' FROM lainausrivi, kirjat, asiakkaat, lainaukset WHERE lainakirja = idkirjat AND lainassa = '1' AND idasiakkaat = lainaaja AND idlainaukset = lainaustunnus";
            connection.Open();
            MySqlDataAdapter daKirjat = new MySqlDataAdapter(kyselyKirjat, connection);
            dtKirjat = new DataTable();
            daKirjat.Fill(dtKirjat);
            dataGridViewKirjat.DataSource = dtKirjat;
            connection.Close();
            // järjestetään taulukko aakkosjärjestykseen tekijän sukunimen perusteella
            dataGridViewKirjat.Sort(dataGridViewKirjat.Columns[2], ListSortDirection.Ascending);

            // jos tullaan kaksoisklikkaamalla Lainaukset sivulta tietyn palautettavan kirjan kanssa tälle lomakkeelle, aktivoidaan palautettavan kirjan rivi
            foreach (DataGridViewRow rivi in dataGridViewKirjat.Rows)
            {
                if (rivi.Cells["tunnus"].Value.ToString() == f1.viedaanPalautus)
                {
                    int index = dataGridViewKirjat.Rows.IndexOf(rivi);
                    if (index >= 0)
                    {
                        dataGridViewKirjat.CurrentCell = dataGridViewKirjat.Rows[index].Cells[0];
                        dataGridViewKirjat.Rows[index].Selected = true;
                        break;
                    }
                }
            }
        }

        private void textBoxHakuKirjat_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtKirjat);
            dv.RowFilter = string.Format("tekijaenimi LIKE '%{0}%' or tekijasnimi LIKE '%{0}%' or Kirja LIKE '%{0}%' or tunnus LIKE '%{0}%' or lainaaja_enimi LIKE '%{0}%' or lainaaja_snimi LIKE '%{0}%'", textBoxHakuKirjat.Text); //multiple column hakukomento!
            dataGridViewKirjat.DataSource = dv;
        }

        private void dataGridViewKirjat_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridViewKirjat.Rows[e.RowIndex];
            lainakirjaIdlainausrivi = row.Cells["tunnus"].Value.ToString();
            palautuskirja = row.Cells["Kirja"].Value.ToString();
        }

        private void buttonPalautaKirja_Click(object sender, EventArgs e)
        {
            PalautaKirjaNappi();
        }

        public void PalautaKirjaNappi()
        {
            if (MessageBox.Show("Haluatko varmasti palauttaa \"" + palautuskirja + "\" kirjan?", "Palautus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // kirjan palautus päivittää tietokantaan tiedot "lainassa=0" ja palautuspäivämäärän
                connection.Open();
                string palautaKysely = "UPDATE kirjat, lainausrivi SET lainassa = 0 WHERE idlainausrivi ='" + lainakirjaIdlainausrivi + "' AND lainakirja = idkirjat";
                MySqlCommand command = new MySqlCommand(palautaKysely, connection);
                command.ExecuteNonQuery();
                palautaKysely = "UPDATE lainausrivi SET palautuspvm = '" + paivaTanaan.ToString("yyyy-MM-dd") + "' WHERE idlainausrivi ='" + lainakirjaIdlainausrivi + "'";
                command = new MySqlCommand(palautaKysely, connection);
                command.ExecuteNonQuery();
                connection.Close();

                HaeTiedot();
            }

        }
    }
}
