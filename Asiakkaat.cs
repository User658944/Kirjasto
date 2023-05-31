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
    public partial class Asiakkaat : Form
    {
        MySqlConnection connection;
        DataTable dt;

        Form1 f1 = new Form1();
        public Asiakkaat(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            connection = new MySqlConnection(f1.kirjastoConnString);
        }

        private void Asiakkaat_Load(object sender, EventArgs e)
        {
            HaeTiedot();
        }

        public void HaeTiedot()
        {
            // haetaan tiedot tietokannan asiakkaat taulusta ja täytetään dataGridViewAsiakkaat
            string kyselyAs = "SELECT idasiakkaat, enimi, snimi, puhnro, sposti FROM asiakkaat WHERE poistunut = '0'";
            connection.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(kyselyAs, connection);
            dt = new DataTable();
            da.Fill(dt);
            dataGridViewAsiakkaat.DataSource = dt;
            connection.Close();

            // järjestetään taulukko aakkosjärjestykseen sukunimen perusteella
            dataGridViewAsiakkaat.Sort(dataGridViewAsiakkaat.Columns[2], ListSortDirection.Ascending);
        }

        private void dataGridViewAsiakkaat_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Valittaessa dataGridViewAsiakkaat listalta rivi aktiiviseksi, rivin tiedot tulevat näkyiin ASIAKASKORTTIIN
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewAsiakkaat.Rows[e.RowIndex];
                labelIdasiakkaat.Text = row.Cells["idasiakkaat"].Value.ToString();
                labelNimi.Text = row.Cells["enimi"].Value.ToString() + " " + row.Cells["snimi"].Value.ToString();
                labelPuhnum.Text = row.Cells["puhnro"].Value.ToString();
                labelSposti.Text = row.Cells["sposti"].Value.ToString();
            }
        }

        private void textBoxHaku_TextChanged(object sender, EventArgs e)
        {
            // Textboksin hakutoiminto datagridview ikkunasta
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("enimi LIKE '%{0}%' or snimi LIKE '%{0}%' or idasiakkaat LIKE '%{0}%'", textBoxHaku.Text); //multiple column hakukomento!
            dataGridViewAsiakkaat.DataSource = dv;
        }

        private void buttonUusiAsiakas_Click(object sender, EventArgs e)
        {
            f1.UusiAsiakasSivu();
        }

        private void buttonPoistaAsiakas_Click(object sender, EventArgs e)
        {
            PoistaAsiakasNappi();
        }

        public void PoistaAsiakasNappi()
        {
            string enimi = dataGridViewAsiakkaat.SelectedRows[0].Cells["enimi"].Value.ToString();
            string snimi = dataGridViewAsiakkaat.SelectedRows[0].Cells["snimi"].Value.ToString();
            string idasiakkaat = dataGridViewAsiakkaat.SelectedRows[0].Cells["idasiakkaat"].Value.ToString();

            // yes/no MessageBox kysymys haluaako käyttävä varmasti poistaa asiakkaan
            if (MessageBox.Show("Haluatko varamasti, että " + enimi + " " + snimi + " poistetaan rekisteristä?", "POISTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // asiakkaan poisto tietokannasta
                string poistokysely = "UPDATE `kirjasto`.`asiakkaat` SET `poistunut` = '1' WHERE idasiakkaat='" + idasiakkaat + "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(poistokysely, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Asiakas " + enimi + " " + snimi + " on nyt poistettu rekisteristä", "Poisto onnistui");
                }
                else
                {
                    MessageBox.Show("Poistaminen ei toteutunut");
                }
                connection.Close();                
            }
            else
            {
                MessageBox.Show("Asiakasta ei poistettu rekisteristä", "Poisto");
            }

            // Ladataan sivu uudelleen että lista päivittyy
            f1.AsiakkaatSivu();
        }
    }
}
