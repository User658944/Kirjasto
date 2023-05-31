using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kirjasto
{
    public partial class Lainaa : Form
    {
        MySqlConnection connection;
        DataTable dtAsiakkaat;
        DataTable dtKirjat;

        DateTime paivaTanaan = DateTime.Now;

        // muuttujat viemään asiakkaan nimi taulusta yhteenvetonäkymään
        public string idasiakkaat = "";
        public string lainaajanNimi = "";

        // muuttujat viemään kirjan tiedot taulusta yhteenvetonäkymään
        public string idkirjat = "";
        public string kirjanNimi = "";

        // muuttuja nimeämään uusi ID lainaukset tauluun tallennettaessa tiedot
        public string idlainaukset = "";

        // muuttuja nimeämään uusi ID lainausrivi tauluun tallennettaessa tiedot
        public string idlainausrivi = "";

        // listBoxien valintamuutokset näkyvät molemmissa listBoxeissa
        public int listBoxValinta = 0;

        Form1 f1 = new Form1();
        public Lainaa(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            connection = new MySqlConnection(f1.kirjastoConnString);
        }
        private void Lainaa_Load(object sender, EventArgs e)
        {
            HaeTiedot();
        }

        public void HaeTiedot()
        {
            // haetaan tiedot tietokannan asiakkaat taulusta ja täytetään dataGridViewAsiakkaat
            string kyselyAs = "SELECT idasiakkaat, enimi, snimi, puhnro, sposti FROM asiakkaat WHERE poistunut = '0'";
            connection.Open();
            MySqlDataAdapter daAs = new MySqlDataAdapter(kyselyAs, connection);
            dtAsiakkaat = new DataTable();
            daAs.Fill(dtAsiakkaat);
            dataGridViewAsiakkaat.DataSource = dtAsiakkaat;
            connection.Close();
            // järjestetään taulukko aakkosjärjestykseen sukunimen perusteella
            dataGridViewAsiakkaat.Sort(dataGridViewAsiakkaat.Columns[2], ListSortDirection.Ascending);

            // haetaan tiedot taulusta kirjat (paitsi kirjastosta poistetut kirjat) ja täytetään dataGridViewKirjat, sekä muutetaan teitokannan lainassa-boolean käyttäjälle ymmärrettäväksi arvoksi
            string kyselyKirjat = "SELECT idkirjat, knimi, tekijaenimi, tekijasnimi FROM kirjat WHERE poistettu = '0' AND lainassa = '0'";
            connection.Open();
            MySqlDataAdapter daKirjat = new MySqlDataAdapter(kyselyKirjat, connection);
            dtKirjat = new DataTable();
            daKirjat.Fill(dtKirjat);
            dataGridViewKirjat.DataSource = dtKirjat;
            connection.Close();
            // järjestetään taulukko aakkosjärjestykseen tekijän sukunimen perusteella
            dataGridViewKirjat.Sort(dataGridViewKirjat.Columns[2], ListSortDirection.Ascending);

            labelLainauspvm.Text = paivaTanaan.ToString("d.M.yyyy");
            labelPalautuspvm.Text = paivaTanaan.AddMonths(1).ToString("d.M.yyyy");

            listBoxIdkirjat.Items.Clear();
            listBoxKirjatNimet.Items.Clear();
            labelIdasiakkaat.Text = "";
            labelLainaaja.Text = "lisää lainaaja";
        }

        private void textBoxHakuLainaaja_TextChanged(object sender, EventArgs e)
        {
            // textBox haku dataGridView taulusta
            DataView dv = new DataView(dtAsiakkaat);
            dv.RowFilter = string.Format("enimi LIKE '%{0}%' or snimi LIKE '%{0}%' or idasiakkaat LIKE '%{0}%'", textBoxHakuLainaaja.Text); //multiple column hakukomento!
            dataGridViewAsiakkaat.DataSource = dv;
        }

        private void textBoxHakuKirja_TextChanged(object sender, EventArgs e)
        {
            // textBox haku dataGridView taulusta
            DataView dv = new DataView(dtKirjat);
            dv.RowFilter = string.Format("tekijaenimi LIKE '%{0}%' or tekijasnimi LIKE '%{0}%' or knimi LIKE '%{0}%' or idkirjat LIKE '%{0}%'", textBoxHakuKirja.Text); //multiple column hakukomento!
            dataGridViewKirjat.DataSource = dv;
        }

        private void dataGridViewAsiakkaat_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewAsiakkaat.Rows[e.RowIndex];
                idasiakkaat = row.Cells["idasiakkaat"].Value.ToString();
                lainaajanNimi = row.Cells["enimi"].Value.ToString() + " " + row.Cells["snimi"].Value.ToString();
            }
        }

        private void dataGridViewKirjat_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewKirjat.Rows[e.RowIndex];
                idkirjat = row.Cells["idkirjat"].Value.ToString();
                kirjanNimi = row.Cells["knimi"].Value.ToString();
            }
        }

        private void buttonLainaa_Click(object sender, EventArgs e)
        {
            if (labelIdasiakkaat.Text != "" && listBoxIdkirjat.Items.Count > 0)
            {
                LainaaNappi();
            }
            else
            {
                MessageBox.Show("Valitse ensin asiakas ja kirjat", "HUOM!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void LainaaNappi()
        {
            if (MessageBox.Show("Lainataanko lisäämäsi kirjat?", "Lainaa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // viedään tiedot lainaukset tauluun
                // haetaan tietokannasta viimeisin ID arvo, jonka perusteella saadaan uusi seuraava tallennettava ID arvo
                string lainaid = "";
                string lainaidkysely = "SELECT * FROM lainaukset order by idlainaukset DESC LIMIT 1 offset 0";

                MySqlCommand command = new MySqlCommand(lainaidkysely, connection);
                MySqlDataReader reader = null;
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    idlainaukset = reader.GetValue(0).ToString();
                    lainaid = idlainaukset;
                    lainaid = lainaid.Substring(lainaid.Length - 6);
                    int lainausnum = Int32.Parse(lainaid) + 1;
                    lainaid = "LA" + lainausnum.ToString();
                    idlainaukset = lainaid;
                }
                else
                {
                    idlainaukset = "LA100001";
                }
                connection.Close();

                string lainauksetTauluun = "INSERT INTO lainaukset VALUES ('" + idlainaukset + "','" + labelIdasiakkaat.Text + "','" + paivaTanaan.ToString("yyyy-MM-dd") + "')";
                command = new MySqlCommand(lainauksetTauluun, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                // viedään tiedot lainausrivi tauluun
                // haetaan tietokannasta viimeisin ID arvo, jonka perusteella saadaan uusi seuraava tallennettava ID arvo
                string lainariviid = "";
                string lainariviidkysely = "SELECT * FROM lainausrivi order by idlainausrivi DESC LIMIT 1 offset 0";

                command = new MySqlCommand(lainariviidkysely, connection);
                reader = null;
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    idlainausrivi = reader.GetValue(0).ToString();
                    lainariviid = idlainausrivi;
                    lainariviid = lainariviid.Substring(lainariviid.Length - 6);
                    int lainausrivinum = Int32.Parse(lainariviid) + 1;
                    lainariviid = "LR" + lainausrivinum.ToString();
                    idlainausrivi = lainariviid;
                }
                else
                {
                    idlainausrivi = "LR100001";
                }
                connection.Close();

                // luetaan lainattavat kirjat listBoxista                
                connection.Open();
                for (int i = 0; i <= (listBoxIdkirjat.Items.Count - 1); i++)
                {
                    string kirjaIDrivi = listBoxIdkirjat.Items[i].ToString();
                    string lainausriviTauluuun = "INSERT INTO lainausrivi VALUES ('" + idlainausrivi + "','" + idlainaukset + "','" + kirjaIDrivi + "','" + paivaTanaan.ToString("yyyy-MM-dd") + "','" + paivaTanaan.AddMonths(1).ToString("yyyy-MM-dd") + "')";
                    command = new MySqlCommand(lainausriviTauluuun, connection);
                    command.ExecuteNonQuery();

                    string kirjaLainattu = "UPDATE kirjat SET lainassa = 1 WHERE idkirjat ='" + kirjaIDrivi + "'";
                    command = new MySqlCommand(kirjaLainattu, connection);
                    command.ExecuteNonQuery();

                    lainariviid = idlainausrivi;
                    lainariviid = lainariviid.Substring(lainariviid.Length - 6);
                    int lainausrivinum = Int32.Parse(lainariviid) + 1;
                    lainariviid = "LR" + lainausrivinum.ToString();
                    idlainausrivi = lainariviid;

                }
                connection.Close();

                HaeTiedot();
            }
        }

        private void buttonVieLainaaja_Click(object sender, EventArgs e)
        {
            labelLainaaja.Text = lainaajanNimi;
            labelIdasiakkaat.Text = idasiakkaat;
        }

        private void buttonVieKirja_Click(object sender, EventArgs e)
        {
            if (listBoxIdkirjat.Items.Contains(idkirjat))
            {}
            else
            {
                listBoxIdkirjat.Items.Add(idkirjat);
                listBoxKirjatNimet.Items.Add(kirjanNimi);
            }
        }

        private void listBoxIdkirjat_SelectedIndexChanged(object sender, EventArgs e)
        {
            // kun valitaan listBoxista indeksi, sama indeksi tulee valituksi myös listBoxKirjatNimet
            listBoxValinta = listBoxIdkirjat.SelectedIndex;
            MuuttunutIndex();
        }

        private void listBoxKirjatNimet_SelectedIndexChanged(object sender, EventArgs e)
        {
            // kun valitaan listBoxista indeksi, sama indeksi tulee valituksi myös listBoxIdkirjat
            listBoxValinta = listBoxKirjatNimet.SelectedIndex;
            MuuttunutIndex();
        }

        public void MuuttunutIndex()
        {
            // aktivoidaan listBoxeihin muuttunut valittu Index
            listBoxKirjatNimet.SelectedIndex = listBoxValinta;
            listBoxIdkirjat.SelectedIndex = listBoxValinta;
        }

        private void buttonPoistaKirjaListalta_Click(object sender, EventArgs e)
        {
            // X-nappi kirjan poistamiseen valittujen kirjojen listalta
            if (listBoxKirjatNimet.SelectedIndex != -1)
            {
                // otetaan talteen valitun elementin indeksi ja poistetaan kirja listalta
                int valittuIndeksi = listBoxKirjatNimet.SelectedIndex;
                listBoxKirjatNimet.Items.RemoveAt(valittuIndeksi);
                listBoxIdkirjat.Items.RemoveAt(valittuIndeksi);
            }
        }
    }
}
