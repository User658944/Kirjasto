
namespace Kirjasto
{
    partial class Lainaa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewKirjat = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelKirjaOtsikko = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxHakuKirja = new System.Windows.Forms.TextBox();
            this.buttonVieKirja = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelLainaajaOtsikko = new System.Windows.Forms.Label();
            this.pictureBoxHae = new System.Windows.Forms.PictureBox();
            this.textBoxHakuLainaaja = new System.Windows.Forms.TextBox();
            this.buttonVieLainaaja = new System.Windows.Forms.Button();
            this.dataGridViewAsiakkaat = new System.Windows.Forms.DataGridView();
            this.buttonLainaa = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelIdasiakkaat = new System.Windows.Forms.Label();
            this.labelLainaaja = new System.Windows.Forms.Label();
            this.listBoxIdkirjat = new System.Windows.Forms.ListBox();
            this.listBoxKirjatNimet = new System.Windows.Forms.ListBox();
            this.labelPpvm = new System.Windows.Forms.Label();
            this.labelPalautuspvm = new System.Windows.Forms.Label();
            this.labelLpvm = new System.Windows.Forms.Label();
            this.labelLainauspvm = new System.Windows.Forms.Label();
            this.buttonPoistaKirjaListalta = new System.Windows.Forms.Button();
            this.labelYv = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKirjat)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHae)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsiakkaat)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewKirjat, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewAsiakkaat, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(656, 519);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewKirjat
            // 
            this.dataGridViewKirjat.AllowUserToAddRows = false;
            this.dataGridViewKirjat.AllowUserToDeleteRows = false;
            this.dataGridViewKirjat.AllowUserToResizeRows = false;
            this.dataGridViewKirjat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewKirjat.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewKirjat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKirjat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKirjat.Location = new System.Drawing.Point(8, 327);
            this.dataGridViewKirjat.MultiSelect = false;
            this.dataGridViewKirjat.Name = "dataGridViewKirjat";
            this.dataGridViewKirjat.ReadOnly = true;
            this.dataGridViewKirjat.RowHeadersVisible = false;
            this.dataGridViewKirjat.RowHeadersWidth = 51;
            this.dataGridViewKirjat.RowTemplate.Height = 24;
            this.dataGridViewKirjat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKirjat.Size = new System.Drawing.Size(630, 189);
            this.dataGridViewKirjat.TabIndex = 6;
            this.dataGridViewKirjat.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKirjat_CellEnter);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel3.Controls.Add(this.labelKirjaOtsikko, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxHakuKirja, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonVieKirja, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 267);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(630, 54);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // labelKirjaOtsikko
            // 
            this.labelKirjaOtsikko.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelKirjaOtsikko.AutoSize = true;
            this.labelKirjaOtsikko.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKirjaOtsikko.Location = new System.Drawing.Point(3, 18);
            this.labelKirjaOtsikko.Name = "labelKirjaOtsikko";
            this.labelKirjaOtsikko.Size = new System.Drawing.Size(188, 36);
            this.labelKirjaOtsikko.TabIndex = 4;
            this.labelKirjaOtsikko.Text = "Vapaat kirjat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.BackgroundImage = global::Kirjasto.Properties.Resources.hakuGray;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(252, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 48);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxHakuKirja
            // 
            this.textBoxHakuKirja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHakuKirja.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHakuKirja.Location = new System.Drawing.Point(302, 13);
            this.textBoxHakuKirja.Name = "textBoxHakuKirja";
            this.textBoxHakuKirja.Size = new System.Drawing.Size(243, 38);
            this.textBoxHakuKirja.TabIndex = 1;
            this.textBoxHakuKirja.TextChanged += new System.EventHandler(this.textBoxHakuKirja_TextChanged);
            // 
            // buttonVieKirja
            // 
            this.buttonVieKirja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVieKirja.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonVieKirja.FlatAppearance.BorderSize = 0;
            this.buttonVieKirja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVieKirja.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVieKirja.ForeColor = System.Drawing.Color.White;
            this.buttonVieKirja.Location = new System.Drawing.Point(552, 3);
            this.buttonVieKirja.Name = "buttonVieKirja";
            this.buttonVieKirja.Size = new System.Drawing.Size(75, 48);
            this.buttonVieKirja.TabIndex = 5;
            this.buttonVieKirja.Text = "➤";
            this.buttonVieKirja.UseVisualStyleBackColor = false;
            this.buttonVieKirja.Click += new System.EventHandler(this.buttonVieKirja_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel2.Controls.Add(this.labelLainaajaOtsikko, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxHae, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxHakuLainaaja, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonVieLainaaja, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 13);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(630, 54);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // labelLainaajaOtsikko
            // 
            this.labelLainaajaOtsikko.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLainaajaOtsikko.AutoSize = true;
            this.labelLainaajaOtsikko.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLainaajaOtsikko.Location = new System.Drawing.Point(3, 18);
            this.labelLainaajaOtsikko.Name = "labelLainaajaOtsikko";
            this.labelLainaajaOtsikko.Size = new System.Drawing.Size(130, 36);
            this.labelLainaajaOtsikko.TabIndex = 4;
            this.labelLainaajaOtsikko.Text = "Lainaaja";
            // 
            // pictureBoxHae
            // 
            this.pictureBoxHae.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxHae.BackgroundImage = global::Kirjasto.Properties.Resources.hakuGray;
            this.pictureBoxHae.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxHae.Location = new System.Drawing.Point(189, 3);
            this.pictureBoxHae.Name = "pictureBoxHae";
            this.pictureBoxHae.Size = new System.Drawing.Size(44, 48);
            this.pictureBoxHae.TabIndex = 0;
            this.pictureBoxHae.TabStop = false;
            // 
            // textBoxHakuLainaaja
            // 
            this.textBoxHakuLainaaja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHakuLainaaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHakuLainaaja.Location = new System.Drawing.Point(239, 13);
            this.textBoxHakuLainaaja.Name = "textBoxHakuLainaaja";
            this.textBoxHakuLainaaja.Size = new System.Drawing.Size(304, 38);
            this.textBoxHakuLainaaja.TabIndex = 1;
            this.textBoxHakuLainaaja.TextChanged += new System.EventHandler(this.textBoxHakuLainaaja_TextChanged);
            // 
            // buttonVieLainaaja
            // 
            this.buttonVieLainaaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVieLainaaja.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonVieLainaaja.FlatAppearance.BorderSize = 0;
            this.buttonVieLainaaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVieLainaaja.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVieLainaaja.ForeColor = System.Drawing.Color.White;
            this.buttonVieLainaaja.Location = new System.Drawing.Point(552, 3);
            this.buttonVieLainaaja.Name = "buttonVieLainaaja";
            this.buttonVieLainaaja.Size = new System.Drawing.Size(75, 48);
            this.buttonVieLainaaja.TabIndex = 5;
            this.buttonVieLainaaja.Text = "➤";
            this.buttonVieLainaaja.UseVisualStyleBackColor = false;
            this.buttonVieLainaaja.Click += new System.EventHandler(this.buttonVieLainaaja_Click);
            // 
            // dataGridViewAsiakkaat
            // 
            this.dataGridViewAsiakkaat.AllowUserToAddRows = false;
            this.dataGridViewAsiakkaat.AllowUserToDeleteRows = false;
            this.dataGridViewAsiakkaat.AllowUserToResizeRows = false;
            this.dataGridViewAsiakkaat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAsiakkaat.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewAsiakkaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsiakkaat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAsiakkaat.Location = new System.Drawing.Point(8, 73);
            this.dataGridViewAsiakkaat.MultiSelect = false;
            this.dataGridViewAsiakkaat.Name = "dataGridViewAsiakkaat";
            this.dataGridViewAsiakkaat.ReadOnly = true;
            this.dataGridViewAsiakkaat.RowHeadersVisible = false;
            this.dataGridViewAsiakkaat.RowHeadersWidth = 51;
            this.dataGridViewAsiakkaat.RowTemplate.Height = 24;
            this.dataGridViewAsiakkaat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAsiakkaat.Size = new System.Drawing.Size(630, 188);
            this.dataGridViewAsiakkaat.TabIndex = 3;
            this.dataGridViewAsiakkaat.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAsiakkaat_CellEnter);
            // 
            // buttonLainaa
            // 
            this.buttonLainaa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLainaa.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonLainaa.FlatAppearance.BorderSize = 0;
            this.buttonLainaa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLainaa.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLainaa.ForeColor = System.Drawing.Color.White;
            this.buttonLainaa.Location = new System.Drawing.Point(208, 468);
            this.buttonLainaa.Name = "buttonLainaa";
            this.buttonLainaa.Size = new System.Drawing.Size(140, 48);
            this.buttonLainaa.TabIndex = 2;
            this.buttonLainaa.Text = "LAINAA";
            this.buttonLainaa.UseVisualStyleBackColor = false;
            this.buttonLainaa.Click += new System.EventHandler(this.buttonLainaa_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.labelIdasiakkaat, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelLainaaja, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.listBoxIdkirjat, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.listBoxKirjatNimet, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelPpvm, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.labelPalautuspvm, 2, 4);
            this.tableLayoutPanel4.Controls.Add(this.labelLpvm, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.labelLainauspvm, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.buttonPoistaKirjaListalta, 2, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(345, 393);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // labelIdasiakkaat
            // 
            this.labelIdasiakkaat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelIdasiakkaat.AutoSize = true;
            this.labelIdasiakkaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdasiakkaat.Location = new System.Drawing.Point(112, 3);
            this.labelIdasiakkaat.Name = "labelIdasiakkaat";
            this.labelIdasiakkaat.Size = new System.Drawing.Size(0, 24);
            this.labelIdasiakkaat.TabIndex = 0;
            // 
            // labelLainaaja
            // 
            this.labelLainaaja.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelLainaaja.AutoSize = true;
            this.labelLainaaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLainaaja.Location = new System.Drawing.Point(123, 3);
            this.labelLainaaja.Name = "labelLainaaja";
            this.labelLainaaja.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLainaaja.Size = new System.Drawing.Size(115, 24);
            this.labelLainaaja.TabIndex = 4;
            this.labelLainaaja.Text = "lisää lainaaja";
            // 
            // listBoxIdkirjat
            // 
            this.listBoxIdkirjat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxIdkirjat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxIdkirjat.FormattingEnabled = true;
            this.listBoxIdkirjat.ItemHeight = 20;
            this.listBoxIdkirjat.Location = new System.Drawing.Point(3, 33);
            this.listBoxIdkirjat.Name = "listBoxIdkirjat";
            this.listBoxIdkirjat.Size = new System.Drawing.Size(109, 257);
            this.listBoxIdkirjat.TabIndex = 8;
            this.listBoxIdkirjat.SelectedIndexChanged += new System.EventHandler(this.listBoxIdkirjat_SelectedIndexChanged);
            // 
            // listBoxKirjatNimet
            // 
            this.listBoxKirjatNimet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxKirjatNimet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxKirjatNimet.FormattingEnabled = true;
            this.listBoxKirjatNimet.ItemHeight = 20;
            this.listBoxKirjatNimet.Location = new System.Drawing.Point(123, 33);
            this.listBoxKirjatNimet.Name = "listBoxKirjatNimet";
            this.listBoxKirjatNimet.Size = new System.Drawing.Size(219, 257);
            this.listBoxKirjatNimet.TabIndex = 9;
            this.listBoxKirjatNimet.SelectedIndexChanged += new System.EventHandler(this.listBoxKirjatNimet_SelectedIndexChanged);
            // 
            // labelPpvm
            // 
            this.labelPpvm.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPpvm.AutoSize = true;
            this.labelPpvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPpvm.Location = new System.Drawing.Point(31, 366);
            this.labelPpvm.Name = "labelPpvm";
            this.labelPpvm.Size = new System.Drawing.Size(81, 24);
            this.labelPpvm.TabIndex = 3;
            this.labelPpvm.Text = "Palautus";
            // 
            // labelPalautuspvm
            // 
            this.labelPalautuspvm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPalautuspvm.AutoSize = true;
            this.labelPalautuspvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPalautuspvm.Location = new System.Drawing.Point(123, 366);
            this.labelPalautuspvm.Name = "labelPalautuspvm";
            this.labelPalautuspvm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPalautuspvm.Size = new System.Drawing.Size(121, 24);
            this.labelPalautuspvm.TabIndex = 7;
            this.labelPalautuspvm.Text = "palautus pvm";
            // 
            // labelLpvm
            // 
            this.labelLpvm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLpvm.AutoSize = true;
            this.labelLpvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLpvm.Location = new System.Drawing.Point(37, 333);
            this.labelLpvm.Name = "labelLpvm";
            this.labelLpvm.Size = new System.Drawing.Size(75, 24);
            this.labelLpvm.TabIndex = 2;
            this.labelLpvm.Text = "Lainaus";
            // 
            // labelLainauspvm
            // 
            this.labelLainauspvm.AutoSize = true;
            this.labelLainauspvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLainauspvm.Location = new System.Drawing.Point(123, 333);
            this.labelLainauspvm.Name = "labelLainauspvm";
            this.labelLainauspvm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLainauspvm.Size = new System.Drawing.Size(110, 24);
            this.labelLainauspvm.TabIndex = 6;
            this.labelLainauspvm.Text = "lainaus pvm";
            // 
            // buttonPoistaKirjaListalta
            // 
            this.buttonPoistaKirjaListalta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPoistaKirjaListalta.BackColor = System.Drawing.Color.Silver;
            this.buttonPoistaKirjaListalta.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonPoistaKirjaListalta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPoistaKirjaListalta.Location = new System.Drawing.Point(302, 296);
            this.buttonPoistaKirjaListalta.Name = "buttonPoistaKirjaListalta";
            this.buttonPoistaKirjaListalta.Size = new System.Drawing.Size(40, 34);
            this.buttonPoistaKirjaListalta.TabIndex = 10;
            this.buttonPoistaKirjaListalta.Text = "X";
            this.buttonPoistaKirjaListalta.UseVisualStyleBackColor = false;
            this.buttonPoistaKirjaListalta.Click += new System.EventHandler(this.buttonPoistaKirjaListalta_Click);
            // 
            // labelYv
            // 
            this.labelYv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelYv.AutoSize = true;
            this.labelYv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYv.Location = new System.Drawing.Point(72, 14);
            this.labelYv.Name = "labelYv";
            this.labelYv.Size = new System.Drawing.Size(206, 32);
            this.labelYv.TabIndex = 4;
            this.labelYv.Text = "YHTEENVETO";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1019, 545);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.buttonLainaa, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.labelYv, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(665, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(351, 519);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // Lainaa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1043, 569);
            this.Controls.Add(this.tableLayoutPanel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1043, 569);
            this.Name = "Lainaa";
            this.Text = "Lainaa";
            this.Load += new System.EventHandler(this.Lainaa_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKirjat)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHae)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsiakkaat)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBoxHae;
        private System.Windows.Forms.TextBox textBoxHakuLainaaja;
        private System.Windows.Forms.Button buttonLainaa;
        private System.Windows.Forms.Label labelLainaajaOtsikko;
        private System.Windows.Forms.DataGridView dataGridViewAsiakkaat;
        private System.Windows.Forms.Label labelYv;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelKirjaOtsikko;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxHakuKirja;
        private System.Windows.Forms.DataGridView dataGridViewKirjat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelIdasiakkaat;
        private System.Windows.Forms.Label labelLpvm;
        private System.Windows.Forms.Label labelPpvm;
        private System.Windows.Forms.Label labelLainaaja;
        private System.Windows.Forms.Label labelLainauspvm;
        private System.Windows.Forms.Label labelPalautuspvm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button buttonVieKirja;
        private System.Windows.Forms.Button buttonVieLainaaja;
        private System.Windows.Forms.ListBox listBoxIdkirjat;
        private System.Windows.Forms.ListBox listBoxKirjatNimet;
        private System.Windows.Forms.Button buttonPoistaKirjaListalta;
    }
}