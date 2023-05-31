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
    public partial class Asiakaspaate : Form
    {
        MySqlConnection connection;
        MySqlCommand command;
        DataTable dt;

        // muuttuja nimeämään uusi ID lainaukset tauluun tallennettaessa tiedot
        public string idlainaukset = "";

        // muuttuja nimeämään uusi ID lainausrivi tauluun tallennettaessa tiedot
        public string idlainausrivi = "";

        // listBoxien valintamuutokset näkyvät molemmissa listBoxeissa
        public int listBoxValinta = 0;

        DateTime paivaTanaan = DateTime.Now;

        Form1 f1 = new Form1();
        public Asiakaspaate(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            connection = new MySqlConnection(f1.kirjastoConnString);
        }
        private void Asiakaspaate_Load(object sender, EventArgs e)
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

            textBoxIdasiakkaat.Text = "";
            textBoxKirjaTunnus.Text = "";
            listBoxIdkirjat.Items.Clear();
            listBoxKirjatNimet.Items.Clear();
            textBoxKirjaTunnusPalauta.Text = "";
            textBoxHaku.Text = "";
        }

        private void textBoxHaku_TextChanged(object sender, EventArgs e)
        {
            //Textboksin hakutoiminto datagridview ikkunasta
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("tekijaenimi LIKE '%{0}%' or tekijasnimi LIKE '%{0}%' or knimi LIKE '%{0}%' or idkirjat LIKE '%{0}%'or lainassa LIKE '%{0}%'", textBoxHaku.Text); //multiple column hakukomento!
            dataGridViewKirjat.DataSource = dv;
        }

        private void buttonPalautaKirja_Click(object sender, EventArgs e)
        {
            PalautaNappi();
        }

        public void PalautaNappi()
        {
            if (textBoxKirjaTunnusPalauta.Text == "KIRJASTO")
            {
                f1.Show();
                this.Close();
            }
            else
            {
                if (textBoxKirjaTunnusPalauta.Text.Length == 8)
                {
                    bool lukee = false;
                    string kirjaidkysely = "SELECT * FROM kirjat WHERE idkirjat ='" + textBoxKirjaTunnusPalauta.Text + "'";
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(kirjaidkysely, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string lainassa = reader.GetString("lainassa");

                        if (lainassa == "0")
                        {
                            MessageBox.Show("Et voi palauttaa kirjaa, jota ei ole lainattu", "Kirja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            lukee = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kirjatunnusta ei löytynyt", "HUOM!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    reader.Close();
                    connection.Close();

                    if (lukee == true)
                    {
                        // kirjan palautus päivittää tietokantaan tiedot "lainassa=0" ja palautuspäivämäärän
                        connection.Open();
                        string palautaKysely = "UPDATE kirjat SET lainassa = 0 WHERE idkirjat ='" + textBoxKirjaTunnusPalauta.Text + "'";
                        command = new MySqlCommand(palautaKysely, connection);
                        command.ExecuteNonQuery();
                        palautaKysely = "UPDATE lainausrivi SET palautuspvm = '" + paivaTanaan.ToString("yyyy-MM-dd") + "' WHERE lainakirja ='" + textBoxKirjaTunnusPalauta.Text + "'";
                        command = new MySqlCommand(palautaKysely, connection);
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Kirja palautettu", "Palauta");
                        HaeTiedot();
                    }
                    lukee = false;
                }
                else
                {
                    MessageBox.Show("Tarkista kirjatunnus!", "HUOM!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            

        }

        private void buttonLainaaKirjat_Click(object sender, EventArgs e)
        {
            if (textBoxIdasiakkaat.Text == "" || textBoxIdasiakkaat.Text.Length != 8)
            {
                MessageBox.Show("Taskista asiakastunnuksesi", "HUOM!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (listBoxIdkirjat.Items.Count > 0)
            {
                bool lukee = false;
                string asidkysely = "SELECT * FROM asiakkaat WHERE idasiakkaat ='" + textBoxIdasiakkaat.Text + "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(asidkysely, connection);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    lukee = true;
                }
                else
                {
                    MessageBox.Show("Asiakastunnusta ei löytynyt", "HUOM!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                reader.Close();
                connection.Close();

                if (lukee == true)
                {
                    LainaaNappi();
                    lukee = false;
                }
            }
            else
            {
                MessageBox.Show("Lisää kirjat", "HUOM!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

                connection.Open();
                MySqlCommand command = new MySqlCommand(lainaidkysely, connection);
                MySqlDataReader reader = null;
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

                string lainauksetTauluun = "INSERT INTO lainaukset VALUES ('" + idlainaukset + "','" + textBoxIdasiakkaat.Text + "','" + paivaTanaan.ToString("yyyy-MM-dd") + "')";
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

        private void buttonLisaaKirja_Click(object sender, EventArgs e)
        {
            LisaaKirjaNappi();
        }

        public void LisaaKirjaNappi()
        {
            if (listBoxIdkirjat.Items.Contains(textBoxKirjaTunnus.Text))
            { }
            else
            {
                string kirjanNimi = "";
                string kirjakysely = "SELECT * FROM kirjat WHERE idkirjat ='" + textBoxKirjaTunnus .Text + "'";
                MySqlCommand command = new MySqlCommand(kirjakysely, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    kirjanNimi = reader.GetString("knimi");
                    string lainassa = reader.GetString("lainassa");

                    if(lainassa == "1")
                    {
                        MessageBox.Show("Kirja on lainassa", "Kirja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        listBoxIdkirjat.Items.Add(textBoxKirjaTunnus.Text);
                        listBoxKirjatNimet.Items.Add(kirjanNimi);
                    }
                }
                connection.Close();

            }
        }

        public void MuuttunutIndex()
        {
            // aktivoidaan listBoxeihin muuttunut valittu Index
            listBoxKirjatNimet.SelectedIndex = listBoxValinta;
            listBoxIdkirjat.SelectedIndex = listBoxValinta;
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

        private void buttonPoistaKirja_Click(object sender, EventArgs e)
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


        // seuraavissa riveissä rajataan ja muokataan käyttäjän syöttämää tekstiä textBoxeihin oikeanlaiseksi
        private void textBoxIdasiakkaat_TextChanged(object sender, EventArgs e)
        {
            if (textBoxIdasiakkaat.Text.Length > 8)
            {
                textBoxIdasiakkaat.Text = textBoxIdasiakkaat.Text.Substring(0, 8);
                textBoxIdasiakkaat.SelectionStart = textBoxIdasiakkaat.Text.Length;
                textBoxIdasiakkaat.SelectionLength = 0;
            }
            else
            {
                textBoxIdasiakkaat.Text = textBoxIdasiakkaat.Text.ToUpper();
                textBoxIdasiakkaat.SelectionStart = textBoxIdasiakkaat.Text.Length;
                textBoxIdasiakkaat.SelectionLength = 0;
            }
        }

        private void textBoxKirjaTunnus_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKirjaTunnus.Text.Length > 8)
            {
                textBoxKirjaTunnus.Text = textBoxKirjaTunnus.Text.Substring(0, 8);
                textBoxKirjaTunnus.SelectionStart = textBoxKirjaTunnus.Text.Length;
                textBoxKirjaTunnus.SelectionLength = 0;
            }
            else
            {
                textBoxKirjaTunnus.Text = textBoxKirjaTunnus.Text.ToUpper();
                textBoxKirjaTunnus.SelectionStart = textBoxKirjaTunnus.Text.Length;
                textBoxKirjaTunnus.SelectionLength = 0;
            }
        }

        private void textBoxKirjaTunnusPalauta_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKirjaTunnusPalauta.Text.Length > 8)
            {
                textBoxKirjaTunnusPalauta.Text = textBoxKirjaTunnusPalauta.Text.Substring(0, 8);
                textBoxKirjaTunnusPalauta.SelectionStart = textBoxKirjaTunnusPalauta.Text.Length;
                textBoxKirjaTunnusPalauta.SelectionLength = 0;
            }
            else
            {
                textBoxKirjaTunnusPalauta.Text = textBoxKirjaTunnusPalauta.Text.ToUpper();
                textBoxKirjaTunnusPalauta.SelectionStart = textBoxKirjaTunnusPalauta.Text.Length;
                textBoxKirjaTunnusPalauta.SelectionLength = 0;
            }
        }

        private void buttonSelaaKirjoja_Click(object sender, EventArgs e)
        {
            HaeTiedot();

            // näytetään
            tableLayoutPanelSelaaKirjoja.Visible = true;
            dataGridViewKirjat.Visible = true;

            // piilotetaan
            buttonPalautaKirja.Visible = false;
            textBoxKirjaTunnusPalauta.Visible = false;
            labelKirjaPalauta.Visible = false;
            tableLayoutPanelLainaa.Visible = false;
        }

        private void buttonPalauta_Click(object sender, EventArgs e)
        {
            HaeTiedot();

            // näytetään
            buttonPalautaKirja.Visible = true;
            textBoxKirjaTunnusPalauta.Visible = true;
            labelKirjaPalauta.Visible = true;

            // piilotetaan
            tableLayoutPanelSelaaKirjoja.Visible = false;
            dataGridViewKirjat.Visible = false;
            tableLayoutPanelLainaa.Visible = false;
        }

        private void buttonLainaa_Click(object sender, EventArgs e)
        {
            HaeTiedot();

            // näytetään
            tableLayoutPanelLainaa.Visible = true;

            // piilotetaan
            buttonPalautaKirja.Visible = false;
            textBoxKirjaTunnusPalauta.Visible = false;
            labelKirjaPalauta.Visible = false;
            tableLayoutPanelSelaaKirjoja.Visible = false;
            dataGridViewKirjat.Visible = false;
        }

        private void textBoxKirjaTunnusPalauta_KeyUp(object sender, KeyEventArgs e)
        {
            // enter näppäimellä siirtyminen seuraavaan kenttään lomakkeella
            if (e.KeyCode == Keys.Enter)
            {
                PalautaNappi();
            }
        }

        private void textBoxIdasiakkaat_KeyUp(object sender, KeyEventArgs e)
        {
            // enter näppäimellä siirtyminen seuraavaan kenttään lomakkeella
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(textBoxIdasiakkaat, true, true, true, true);
            }
        }

        private void textBoxKirjaTunnus_KeyUp(object sender, KeyEventArgs e)
        {
            // enter näppäimellä lisätään kirja listboksiin
            if (e.KeyCode == Keys.Enter)
            {
                LisaaKirjaNappi();
            }
        }
    }
}
