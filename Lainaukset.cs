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
    public partial class Lainaukset : Form
    {
        MySqlConnection connection;
        DataTable dtTapahtumat;

        Form1 f1 = new Form1();
        public Lainaukset(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            connection = new MySqlConnection(f1.kirjastoConnString);
        }

        private void Lainaukset_Load(object sender, EventArgs e)
        {
            HaeTiedot();

            // tällä saadaan päivitettyä myöhässä olevat palautukset
            // päivitys ei onnistu formin Load tapahtumassa vaan pitää käyttää dataGridView-tapahtumaa, tässä tapauksessa Visible
            dataGridViewTapahtumat.Visible = true;
        }

        public void HaeTiedot()
        {
            // haetaan lainaustapahtumat, eli kaikki lainausrivit lainausrivit taulusta, sekä muita oleellisia teitoja kättäjälle, kuten lainaajan nimi ja kirjan nimi
            string lainausKysely = "SELECT idlainausrivi, lainaustunnus AS 'tunnus', CASE WHEN lainassa = '0' THEN 'ei' ELSE 'kyllä' END AS lainassa, lainakirja, knimi, lainauspvm, palautuspvm, idasiakkaat AS 'as_id', enimi AS 'lainaaja_enimi', snimi AS 'lainaaja_snimi' FROM lainausrivi, kirjat, asiakkaat, lainaukset WHERE idkirjat = lainakirja AND lainaustunnus = idlainaukset AND lainaaja = idasiakkaat ORDER BY idlainausrivi DESC";
            connection.Open();
            MySqlDataAdapter daRivi = new MySqlDataAdapter(lainausKysely, connection);
            dtTapahtumat = new DataTable();
            daRivi.Fill(dtTapahtumat);
            dataGridViewTapahtumat.DataSource = dtTapahtumat;
            connection.Close();
        }

        private void dataGridViewTapahtumat_VisibleChanged(object sender, EventArgs e)
        {
            // käytetään tässä tapahtumaa "VisibleChanged" taululle formin latauksen yhteydessä
            // näin saadaan päivitettyä myöhästyneet palautukset näkyviin
            // muutetaan dataGridView-solujen väri jos palautus on myöhässä
            DateTime nykyinenPvm = DateTime.Now;
            foreach (DataGridViewRow rivi in dataGridViewTapahtumat.Rows)
            {
                string lainassa = rivi.Cells["lainassa"].Value.ToString();
                DateTime lainausPvm = DateTime.Parse(rivi.Cells["lainauspvm"].Value.ToString());
                if (lainausPvm.AddMonths(1) < nykyinenPvm && lainassa == "kyllä")
                {
                    rivi.Cells["palautuspvm"].Value = lainausPvm.AddMonths(1).ToString();
                    rivi.Cells["palautuspvm"].ErrorText = "myöhässä";   // huomiomerkki!
                    rivi.Cells["lainauspvm"].Style.BackColor = Color.LightPink;
                    rivi.Cells["palautuspvm"].Style.BackColor = Color.LightPink;
                }
            }
        }

        private void dataGridViewTapahtumat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // jos kirja on lainassa, kaksoisklikkaamalla pääsee kirjan palautussivulle palauttamaan kirjan
            if (dataGridViewTapahtumat.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewTapahtumat.SelectedRows[0];
                string lainassa = selectedRow.Cells["lainassa"].Value.ToString();
                if (lainassa == "kyllä")
                {
                    f1.viedaanPalautus = selectedRow.Cells["idlainausrivi"].Value.ToString();
                    f1.PalautaSivu();
                }
            }
        }

        private void textBoxHakuLainaustapahtumat_TextChanged(object sender, EventArgs e)
        {
            // Textboksin hakutoiminto datagridview ikkunasta
            DataView dv = new DataView(dtTapahtumat);
            dv.RowFilter = string.Format("idlainausrivi LIKE '%{0}%' or tunnus LIKE '%{0}%' or lainassa LIKE '%{0}%' or lainakirja LIKE '%{0}%' or knimi LIKE '%{0}%' or as_id LIKE '%{0}%' or lainaaja_enimi LIKE '%{0}%' or lainaaja_snimi LIKE '%{0}%'", textBoxHakuLainaustapahtumat.Text); //multiple column hakukomento!
            dataGridViewTapahtumat.DataSource = dv;

            // Visible käytettävä false/true, että myöhässä olevien kirjojen palautuspäivämääräkenttä näkyy punaisena
            // koska tapahtuma pitää sitoa johonkin dataGridView tapahtumaan että se toteutuu
            dataGridViewTapahtumat.Visible = false;
            dataGridViewTapahtumat.Visible = true;
        }
    }
}
