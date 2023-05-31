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
    public partial class Form1 : Form
    {
        public string kirjasto = "Kaupungin Kirjasto";
        public string yTunnus = "1234567-8";
        public string osoite = "Kaupunkikatu 10";

        // Oman koneen serveri
        public string server = "localhost";
        public string userId = "root";
        public string password = "salasana";
        public string database = "kirjasto";

        public string kirjastoConnString;

        // muuttuja viemään palautettavan kirjan tunnus Lainaukset sivulta Palauta sivulle
        public string viedaanPalautus;

        public Form1()
        {
            InitializeComponent();
            kirjastoConnString = "server="+server+";user id="+userId+";password="+password+";database="+database+";persistsecurityinfo=True";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button buttonLainaukset = new Button() { Size = new Size(140, 44) };
            Button buttonLainaa = new Button() { Size = new Size(140, 44) };
            Button buttonPalauta = new Button() { Size = new Size(140, 44) };
            Button buttonAsiakkaat = new Button() { Size = new Size(140, 44) };
            Button buttonKirjat = new Button() { Size = new Size(140, 44) };
            Button buttonAsetukset = new Button() { Size = new Size(140, 44) };
        }

        private void buttonLainaukset_Click(object sender, EventArgs e)
        {
            LainauksetSivu();
        }

        public void LainauksetSivu()
        {
            buttonLainaukset.BackColor = Color.WhiteSmoke;
            buttonLainaa.BackColor = Color.Gainsboro;
            buttonPalauta.BackColor = Color.Gainsboro;
            buttonAsiakkaat.BackColor = Color.Gainsboro;
            buttonKirjat.BackColor = Color.Gainsboro;
            buttonAsetukset.BackColor = Color.Gainsboro;

            // tuodaan formi näkyviin panelMain komponenttiin
            Lainaukset lainaukset = new Lainaukset(this);
            lainaukset.TopLevel = false;
            panelMain.Controls.Add(lainaukset);
            lainaukset.BringToFront();
            lainaukset.Show();
            lainaukset.Dock = DockStyle.Fill;
        }

        private void buttonLainaa_Click(object sender, EventArgs e)
        {
            LainaaSivu();
        }

        public void LainaaSivu()
        {
            buttonLainaukset.BackColor = Color.Gainsboro;
            buttonLainaa.BackColor = Color.WhiteSmoke;
            buttonPalauta.BackColor = Color.Gainsboro;
            buttonAsiakkaat.BackColor = Color.Gainsboro;
            buttonKirjat.BackColor = Color.Gainsboro;
            buttonAsetukset.BackColor = Color.Gainsboro;

            // tuodaan formi näkyviin panelMain komponenttiin
            Lainaa lai = new Lainaa(this);
            lai.TopLevel = false;
            panelMain.Controls.Add(lai);
            lai.BringToFront();
            lai.Show();
            lai.Dock = DockStyle.Fill;
        }

        private void buttonPalauta_Click(object sender, EventArgs e)
        {
            // kirjojen palautussivu
            PalautaSivu();
        }

        public void PalautaSivu()
        {
            buttonLainaukset.BackColor = Color.Gainsboro;
            buttonLainaa.BackColor = Color.Gainsboro;
            buttonPalauta.BackColor = Color.WhiteSmoke;
            buttonAsiakkaat.BackColor = Color.Gainsboro;
            buttonKirjat.BackColor = Color.Gainsboro;
            buttonAsetukset.BackColor = Color.Gainsboro;

            // tuodaan formi näkyviin panelMain komponenttiin
            Palauta pal = new Palauta(this);
            pal.TopLevel = false;
            panelMain.Controls.Add(pal);
            pal.BringToFront();
            pal.Show();
            pal.Dock = DockStyle.Fill;
        }

        private void buttonAsiakkaat_Click(object sender, EventArgs e)
        {
            AsiakkaatSivu();
        }

        public void AsiakkaatSivu()
        {
            buttonLainaukset.BackColor = Color.Gainsboro;
            buttonLainaa.BackColor = Color.Gainsboro;
            buttonPalauta.BackColor = Color.Gainsboro;
            buttonAsiakkaat.BackColor = Color.WhiteSmoke;
            buttonKirjat.BackColor = Color.Gainsboro;
            buttonAsetukset.BackColor = Color.Gainsboro;

            // tuodaan formi näkyviin panelMain komponenttiin
            Asiakkaat asi = new Asiakkaat(this);
            asi.TopLevel = false;
            panelMain.Controls.Add(asi);
            asi.BringToFront();
            asi.Show();
            asi.Dock = DockStyle.Fill;            
        }

        private void buttonKirjat_Click(object sender, EventArgs e)
        {
            KirjatSivu();
        }

        public void KirjatSivu()
        {
            buttonLainaukset.BackColor = Color.Gainsboro;
            buttonLainaa.BackColor = Color.Gainsboro;
            buttonPalauta.BackColor = Color.Gainsboro;
            buttonAsiakkaat.BackColor = Color.Gainsboro;
            buttonKirjat.BackColor = Color.WhiteSmoke;
            buttonAsetukset.BackColor = Color.Gainsboro;

            // tuodaan formi näkyviin panelMain komponenttiin
            Kirjat kir = new Kirjat(this);
            kir.TopLevel = false;
            panelMain.Controls.Add(kir);
            kir.BringToFront();
            kir.Show();
            kir.Dock = DockStyle.Fill;
        }

        private void buttonAsetukset_Click(object sender, EventArgs e)
        {
            AsetuksetSivu();
        }

        public void AsetuksetSivu()
        {
            buttonLainaukset.BackColor = Color.Gainsboro;
            buttonLainaa.BackColor = Color.Gainsboro;
            buttonPalauta.BackColor = Color.Gainsboro;
            buttonAsiakkaat.BackColor = Color.Gainsboro;
            buttonKirjat.BackColor = Color.Gainsboro;
            buttonAsetukset.BackColor = Color.WhiteSmoke;

            // tuodaan formi näkyviin panelMain komponenttiin
            Asetukset ase = new Asetukset(this);
            ase.TopLevel = false;
            panelMain.Controls.Add(ase);
            ase.BringToFront();
            ase.Show();
            ase.Dock = DockStyle.Fill;
        }

        public void UusiAsiakasSivu()
        {
            // tuodaan formi näkyviin panlMain komponenttiin
            UusiAsiakas uusi = new UusiAsiakas(this);
            uusi.TopLevel = false;
            panelMain.Controls.Add(uusi);
            uusi.BringToFront();
            uusi.Show();
            uusi.Dock = DockStyle.Fill;
        }

        private void buttonSulje_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void AsiakaspaateSivu()
        {
            Asiakaspaate aspaate = new Asiakaspaate(this);
            aspaate.BringToFront();
            aspaate.Show();
        }
    }
}
