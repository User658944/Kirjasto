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
    public partial class UusiAsiakas : Form
    {
        MySqlConnection connection;

        Form1 f1 = new Form1();
        public UusiAsiakas(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            connection = new MySqlConnection(f1.kirjastoConnString);
        }

        private void UusiAsiakas_Load(object sender, EventArgs e)
        {
            // haetaan tietokannasta viimeisin ID arvo, jonka perusteella saadaan uusi seuraava tallennettava ID arvo
            string asid = "";     //luodaan muuttuja uudelle IDlle

            MySqlCommand command = new MySqlCommand();
            MySqlDataReader reader = null;
            command.Connection = connection;
            command.CommandText = "SELECT * FROM asiakkaat order by idasiakkaat DESC LIMIT 1 offset 0";   //MySql komento etsii suurimman ID:n taulukosta
            connection.Open();
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                textBoxIdasiakkaat.Text = reader.GetValue(0).ToString();
                asid = textBoxIdasiakkaat.Text;
                asid = asid.Substring(asid.Length - 6);
                int asnum = Int32.Parse(asid) + 1;
                asid = "AS" + asnum.ToString();
                textBoxIdasiakkaat.Text = asid;
            }
            else
            {
                textBoxIdasiakkaat.Text = "AS100001";
            }
            connection.Close();

            // Tällä rivillä saadaan kursori ensimmäiselle täytettävälle tekstikentälle tällä formilla (käyttäjäystävällisyyttä)
            this.SelectNextControl(labelEtunimi, true, true, true, true);
        }

        private void textBoxEnimi_KeyUp(object sender, KeyEventArgs e)
        {
            // enter näppäimellä siirtyminen seuraavaan kenttään lomakkeella
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(textBoxEnimi, true, true, true, true);
            }
        }

        private void textBoxSnimi_KeyUp(object sender, KeyEventArgs e)
        {
            // enter näppäimellä siirtyminen seuraavaan kenttään lomakkeella
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(textBoxSnimi, true, true, true, true);
            }
        }

        private void textBoxPuhnro_KeyUp(object sender, KeyEventArgs e)
        {
            // enter näppäimellä siirtyminen seuraavaan kenttään lomakkeella
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(textBoxPuhnro, true, true, true, true);
            }
        }

        private void textBoxSposti_KeyUp(object sender, KeyEventArgs e)
        {
            // enter näppäimellä siirtyminen seuraavaan kenttään lomakkeella
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(textBoxSposti, true, true, true, true);
            }
        }

        private void buttonTallenna_Click(object sender, EventArgs e)
        {
            TallennaNappi();
        }

        public void TallennaNappi()
        {
            if (textBoxEnimi.Text != "" && textBoxSnimi.Text != "" && textBoxPuhnro.Text != "" && textBoxSposti.Text != "")
            {
                string tallenna = "INSERT INTO asiakkaat VALUES('" + textBoxIdasiakkaat.Text + "','" + textBoxEnimi.Text + "','" + textBoxSnimi.Text + "','" + textBoxPuhnro.Text + "','" + textBoxSposti.Text + "','0')";
                MySqlCommand command = new MySqlCommand(tallenna, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Asiakas tallennettu onnistuneesti", "Uusi Asiakas");

                // Ladataan sivu uudelleen että lista päivittyy
                f1.AsiakkaatSivu();
            }
            else
            {
                MessageBox.Show("Täytä kaikki kentät!", "HUOM!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxEnimi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // sallitaan nimikenttään vain kirjaimia
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxSnimi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // sallitaan nimikenttään vain kirjaimia
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPuhnro_KeyPress(object sender, KeyPressEventArgs e)
        {
            // sallitaan numerokenttään vain numeroita
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxSposti_KeyPress(object sender, KeyPressEventArgs e)
        {
            // estetään välilyönnin käyttäminen sähköpostikenttään
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonTakaisin_Click(object sender, EventArgs e)
        {
            f1.AsiakkaatSivu();
        }
    }
}
