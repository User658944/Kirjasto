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
    public partial class Asetukset : Form
    {
        MySqlConnection connection;

        Form1 f1 = new Form1();
        public Asetukset(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            connection = new MySqlConnection(f1.kirjastoConnString);
        }

        private void Asetukset_Load(object sender, EventArgs e)
        {
            HaeTiedot();
        }

        public void HaeTiedot()
        {
            textBoxPalvelin.Text = f1.server;
            textBoxTietokanta.Text = f1.database;
            textBoxKayttajanimi.Text = f1.userId;
            textBoxSalasana.Text = f1.password;

            textBoxKirjastonNimi.Text = f1.kirjasto;
            textBoxYtunnus.Text = f1.yTunnus;
            textBoxOsoite.Text = f1.osoite;
        }        
        
        private void buttonTietokanta_Click(object sender, EventArgs e)
        {
            if (textBoxPalvelin.Enabled == false)
            {
                if (MessageBox.Show("Haluatko varmasti muuttaa tietokantaa?\nTämä voi vaikuttaa merkittävästi ohjelman toimintaan!", "HUOM!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    textBoxPalvelin.Enabled = true;
                    textBoxTietokanta.Enabled = true;
                    textBoxKayttajanimi.Enabled = true;
                    textBoxSalasana.Enabled = true;
                    buttonTallennaTietokanta.Visible = true;
                }
            }
            else
            {
                LukitseTietokantamuokkaus();
                // lukittaessa tietokannan muokkausmahdollisuus, haetaan myös viimeksi toimivat tietokantayhteys tiedot textBoxeihin
                HaeTiedot();
            }
        }

        public void LukitseTietokantamuokkaus()
        {
            textBoxPalvelin.Enabled = false;
            textBoxTietokanta.Enabled = false;
            textBoxKayttajanimi.Enabled = false;
            textBoxSalasana.Enabled = false;
            buttonTallennaTietokanta.Visible = false;
        }

        private void buttonTallennaTietokanta_Click(object sender, EventArgs e)
        {            
            yhteysTesti();
        }

        public void yhteysTesti()
        {
            // luodaan uusi connection string kokeiltavaksi uutta yhteyttä, mutta ei vielä tallenneta uuden yhteyden muuttujien tietoja jos yhteys ei toimikkaan
            f1.kirjastoConnString = "server=" + textBoxPalvelin.Text + ";user id=" + textBoxKayttajanimi.Text + ";password=" + textBoxSalasana.Text + ";database=" + textBoxTietokanta.Text + ";persistsecurityinfo=True;allowuservariables=True";
            try
            {
                MySqlConnection connection = new MySqlConnection(f1.kirjastoConnString);
                connection.Open();
                MessageBox.Show("Teitokantayhteys-Testi toimi \uD83D\uDC4D", "Testi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();

                // jos uusi tietokantayhteys toimi, tallennetaan tietokantayhteyden muuttujiin uudet arvot
                f1.server = textBoxPalvelin.Text;
                f1.database = textBoxTietokanta.Text;
                f1.userId = textBoxKayttajanimi.Text;
                f1.password = textBoxSalasana.Text;

                LukitseTietokantamuokkaus();
                // päivitetään palvelimen yhteyden uudet tietueet formille
                HaeTiedot();
            }
            catch
            {
                MessageBox.Show("Teitokantayhteys ei toimi. Tarkista täyttämäsi kentät", "HUOM!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // jos uusi tietokantayhteys ei toiminut, palautetaan tietokannan connection string alkuperäiseen
                f1.kirjastoConnString = "server=" + f1.server + ";user id=" + f1.userId + ";password=" + f1.password + ";database=" + f1.database + ";persistsecurityinfo=True";
            }
        }

        private void buttonKayttaja_Click(object sender, EventArgs e)
        {
            if (textBoxKirjastonNimi.Enabled == false)
            {
                if (MessageBox.Show("Haluatko varmasti muuttaa perustietoja?", "HUOM!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    textBoxKirjastonNimi.Enabled = true;
                    textBoxYtunnus.Enabled = true;
                    textBoxOsoite.Enabled = true;
                    buttonTallennaKayttaja.Visible = true;
                }
            }
            else
            {
                textBoxKirjastonNimi.Enabled = false;
                textBoxYtunnus.Enabled = false;
                textBoxOsoite.Enabled = false;
                buttonTallennaKayttaja.Visible = false;

                HaeTiedot();
            }
        }

        private void buttonTallennaKayttaja_Click(object sender, EventArgs e)
        {
            TallennaKayttajaNappi();
        }

        public void TallennaKayttajaNappi()
        {
            f1.kirjasto = textBoxKirjastonNimi.Text;
            f1.yTunnus = textBoxYtunnus.Text;
            f1.osoite = textBoxOsoite.Text;

            textBoxKirjastonNimi.Enabled = false;
            textBoxYtunnus.Enabled = false;
            textBoxOsoite.Enabled = false;
            buttonTallennaKayttaja.Visible = false;

            HaeTiedot();

            MessageBox.Show("Uudet titdot tallennettu");
        }

        private void buttonAsiakaspaate_Click(object sender, EventArgs e)
        {
            f1.AsiakaspaateSivu();
            f1.Hide();
        }
    }
}
