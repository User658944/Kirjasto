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
    public partial class Kirjat : Form
    {
        MySqlConnection connection;
        DataTable dt;

        Form1 f1 = new Form1();
        public Kirjat(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            connection = new MySqlConnection(f1.kirjastoConnString);
        }

        private void Kirjat_Load(object sender, EventArgs e)
        {
            HaeTiedot();
        }

        public void HaeTiedot()
        {
            dataGridViewKirjat.Font = new Font("Calibri", 12);

            // haetaan tiedot taulusta kirjat (paitsi kirjastosta poistetut kirjat) ja täytetään dataGridViewKirjat, sekä muutetaan teitokannan lainassa-boolean käyttäjälle ymmärrettäväksi arvoksi (kyllä/ei)
            string kyselyKirjat = "SELECT idkirjat, knimi, tekijaenimi, tekijasnimi, CASE WHEN lainassa = '0' THEN 'ei' ELSE 'kyllä' END AS lainassa FROM kirjat WHERE poistettu = '0'";
            connection.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(kyselyKirjat, connection);
            dt = new DataTable();
            da.Fill(dt);
            dataGridViewKirjat.DataSource = dt;
            connection.Close();

            // järjestetään taulukko aakkosjärjestykseen tekijän sukunimen perusteella
            dataGridViewKirjat.Sort(dataGridViewKirjat.Columns[2], ListSortDirection.Ascending);
        }

        private void textBoxHaku_TextChanged(object sender, EventArgs e)
        {
            // Textboksin hakutoiminto datagridview ikkunasta
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("tekijaenimi LIKE '%{0}%' or tekijasnimi LIKE '%{0}%' or knimi LIKE '%{0}%' or idkirjat LIKE '%{0}%'or lainassa LIKE '%{0}%'", textBoxHaku.Text); //multiple column hakukomento!
            dataGridViewKirjat.DataSource = dv;
        }

        private void buttonLisaaKirja_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanelLisaaKirja.Visible == true)
            {
                tableLayoutPanelLisaaKirja.Visible = false;
                textBoxKnimi.Text = "";
                textBoxTekijaenimi.Text = "";
                textBoxTekijasnimi.Text = "";
            }
            else
            {
                LisaaKirjaNappi();
            }
        }

        public void LisaaKirjaNappi()
        {
            tableLayoutPanelLisaaKirja.Visible = true;
        }

        private void buttonTallennaKirja_Click(object sender, EventArgs e)
        {
            TallennaKirjaNappi();
        }

        public void TallennaKirjaNappi()
        {
            // haetaan tietokannasta viimeisin ID arvo, jonka perusteella saadaan uusi seuraava tallennettava ID arvo
            string viimeisinId = "";
            string uusiId = "";

            MySqlCommand command = new MySqlCommand();
            MySqlDataReader lukija = null;
            command.Connection = connection;
            command.CommandText = "SELECT * FROM kirjat order by idkirjat DESC LIMIT 1 offset 0";   // MySql komento etsii suurimman ID:n taulukosta
            connection.Open();
            lukija = command.ExecuteReader();

            if (lukija.Read())
            {
                uusiId = lukija.GetValue(0).ToString();
                viimeisinId = uusiId;
                viimeisinId = viimeisinId.Substring(viimeisinId.Length - 6);
                int idnum = Int32.Parse(viimeisinId) + 1;
                viimeisinId = "KI" + idnum.ToString();
                uusiId = viimeisinId;
            }
            else
            {
                uusiId = "KI100001";
            }
            connection.Close();

            if (textBoxKnimi.Text != "" && textBoxTekijaenimi.Text != "" && textBoxTekijasnimi.Text != "")
            {
                // viedään uuden kirjan tiedot tietokantaan
                string lisaaKirja = "INSERT INTO kirjat VALUES('" + uusiId + "','" + textBoxKnimi.Text + "','" + textBoxTekijaenimi.Text + "','" + textBoxTekijasnimi.Text + "','0','0')";
                command = new MySqlCommand(lisaaKirja, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Uuden kirjan tiedot tallennettu!", "Tallenna", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tableLayoutPanelLisaaKirja.Visible = false;
                textBoxKnimi.Text = "";
                textBoxTekijaenimi.Text = "";
                textBoxTekijasnimi.Text = "";

                f1.KirjatSivu();
            }
            else
            {
                MessageBox.Show("Täytä kaikki uuden kirjan kentät!", "HUOM!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonPoistaKirja_Click(object sender, EventArgs e)
        {
            PoistaKirjaNappi();
        }

        public void PoistaKirjaNappi()
        {
            string knimi = dataGridViewKirjat.SelectedRows[0].Cells["knimi"].Value.ToString();
            string tekijaenimi = dataGridViewKirjat.SelectedRows[0].Cells["tekijaenimi"].Value.ToString();
            string tekijasnimi = dataGridViewKirjat.SelectedRows[0].Cells["tekijasnimi"].Value.ToString();

            // kirjan poistaminen teitokannasta aiheuttaisi ongelmia lainaushistoriahauissa, joten merkitään kirja teitokantaan poistetuksi kirjastosta
            string poitoKysely = "UPDATE kirjat SET `poistettu` = '1' WHERE knimi='" + knimi + "' AND tekijaenimi='" + tekijaenimi + "' AND tekijasnimi='" + tekijasnimi + "'";

            if (MessageBox.Show("Haluatko varmasti poistaa \""+knimi+"\" kirjan kirjaston rekisteritä?", "HUOM!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(poitoKysely, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Kirja poistettu kirjastosta", "Poistettu");
                    HaeTiedot();
                }
                catch
                {
                    MessageBox.Show("Kirjan poisto ei onnistunut", "HUOM!");
                }                
            }            
        }
    }
}
