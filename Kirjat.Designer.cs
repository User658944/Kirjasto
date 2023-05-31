
namespace Kirjasto
{
    partial class Kirjat
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxHae = new System.Windows.Forms.PictureBox();
            this.textBoxHaku = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelLisaaKirja = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxKnimi = new System.Windows.Forms.TextBox();
            this.labelKirjannimi = new System.Windows.Forms.Label();
            this.textBoxTekijaenimi = new System.Windows.Forms.TextBox();
            this.labelTekijaenimi = new System.Windows.Forms.Label();
            this.textBoxTekijasnimi = new System.Windows.Forms.TextBox();
            this.labelTekijasnimi = new System.Windows.Forms.Label();
            this.buttonTallennaKirja = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonLisaaKirja = new System.Windows.Forms.Button();
            this.buttonPoistaKirja = new System.Windows.Forms.Button();
            this.labelKirjatLOtsikko = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKirjat)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHae)).BeginInit();
            this.tableLayoutPanelLisaaKirja.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.960784F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.07843F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.960784F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewKirjat, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelLisaaKirja, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1018, 544);
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
            this.dataGridViewKirjat.Location = new System.Drawing.Point(22, 63);
            this.dataGridViewKirjat.MultiSelect = false;
            this.dataGridViewKirjat.Name = "dataGridViewKirjat";
            this.dataGridViewKirjat.ReadOnly = true;
            this.dataGridViewKirjat.RowHeadersVisible = false;
            this.dataGridViewKirjat.RowHeadersWidth = 51;
            this.dataGridViewKirjat.RowTemplate.Height = 24;
            this.dataGridViewKirjat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKirjat.Size = new System.Drawing.Size(972, 298);
            this.dataGridViewKirjat.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel2.Controls.Add(this.labelKirjatLOtsikko, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxHaku, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxHae, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(22, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(972, 54);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // pictureBoxHae
            // 
            this.pictureBoxHae.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxHae.BackgroundImage = global::Kirjasto.Properties.Resources.hakuGray;
            this.pictureBoxHae.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxHae.Location = new System.Drawing.Point(458, 3);
            this.pictureBoxHae.Name = "pictureBoxHae";
            this.pictureBoxHae.Size = new System.Drawing.Size(54, 48);
            this.pictureBoxHae.TabIndex = 0;
            this.pictureBoxHae.TabStop = false;
            // 
            // textBoxHaku
            // 
            this.textBoxHaku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHaku.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHaku.Location = new System.Drawing.Point(518, 8);
            this.textBoxHaku.Name = "textBoxHaku";
            this.textBoxHaku.Size = new System.Drawing.Size(451, 38);
            this.textBoxHaku.TabIndex = 1;
            this.textBoxHaku.TextChanged += new System.EventHandler(this.textBoxHaku_TextChanged);
            // 
            // tableLayoutPanelLisaaKirja
            // 
            this.tableLayoutPanelLisaaKirja.ColumnCount = 6;
            this.tableLayoutPanelLisaaKirja.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelLisaaKirja.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelLisaaKirja.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelLisaaKirja.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelLisaaKirja.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelLisaaKirja.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanelLisaaKirja.Controls.Add(this.textBoxKnimi, 0, 1);
            this.tableLayoutPanelLisaaKirja.Controls.Add(this.labelKirjannimi, 0, 0);
            this.tableLayoutPanelLisaaKirja.Controls.Add(this.textBoxTekijaenimi, 2, 1);
            this.tableLayoutPanelLisaaKirja.Controls.Add(this.labelTekijaenimi, 2, 0);
            this.tableLayoutPanelLisaaKirja.Controls.Add(this.textBoxTekijasnimi, 4, 1);
            this.tableLayoutPanelLisaaKirja.Controls.Add(this.labelTekijasnimi, 4, 0);
            this.tableLayoutPanelLisaaKirja.Controls.Add(this.buttonTallennaKirja, 5, 1);
            this.tableLayoutPanelLisaaKirja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLisaaKirja.Location = new System.Drawing.Point(22, 427);
            this.tableLayoutPanelLisaaKirja.Name = "tableLayoutPanelLisaaKirja";
            this.tableLayoutPanelLisaaKirja.RowCount = 2;
            this.tableLayoutPanelLisaaKirja.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLisaaKirja.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanelLisaaKirja.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelLisaaKirja.Size = new System.Drawing.Size(972, 114);
            this.tableLayoutPanelLisaaKirja.TabIndex = 5;
            this.tableLayoutPanelLisaaKirja.Visible = false;
            // 
            // textBoxKnimi
            // 
            this.textBoxKnimi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKnimi.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKnimi.Location = new System.Drawing.Point(3, 59);
            this.textBoxKnimi.Name = "textBoxKnimi";
            this.textBoxKnimi.Size = new System.Drawing.Size(234, 35);
            this.textBoxKnimi.TabIndex = 7;
            // 
            // labelKirjannimi
            // 
            this.labelKirjannimi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelKirjannimi.AutoSize = true;
            this.labelKirjannimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKirjannimi.Location = new System.Drawing.Point(3, 32);
            this.labelKirjannimi.Name = "labelKirjannimi";
            this.labelKirjannimi.Size = new System.Drawing.Size(100, 24);
            this.labelKirjannimi.TabIndex = 3;
            this.labelKirjannimi.Text = "Kirjan Nimi";
            // 
            // textBoxTekijaenimi
            // 
            this.textBoxTekijaenimi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTekijaenimi.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTekijaenimi.Location = new System.Drawing.Point(263, 59);
            this.textBoxTekijaenimi.Name = "textBoxTekijaenimi";
            this.textBoxTekijaenimi.Size = new System.Drawing.Size(235, 35);
            this.textBoxTekijaenimi.TabIndex = 8;
            // 
            // labelTekijaenimi
            // 
            this.labelTekijaenimi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTekijaenimi.AutoSize = true;
            this.labelTekijaenimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTekijaenimi.Location = new System.Drawing.Point(263, 32);
            this.labelTekijaenimi.Name = "labelTekijaenimi";
            this.labelTekijaenimi.Size = new System.Drawing.Size(137, 24);
            this.labelTekijaenimi.TabIndex = 4;
            this.labelTekijaenimi.Text = "Tekijän etunimi";
            // 
            // textBoxTekijasnimi
            // 
            this.textBoxTekijasnimi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTekijasnimi.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTekijasnimi.Location = new System.Drawing.Point(524, 59);
            this.textBoxTekijasnimi.Name = "textBoxTekijasnimi";
            this.textBoxTekijasnimi.Size = new System.Drawing.Size(235, 35);
            this.textBoxTekijasnimi.TabIndex = 9;
            // 
            // labelTekijasnimi
            // 
            this.labelTekijasnimi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTekijasnimi.AutoSize = true;
            this.labelTekijasnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTekijasnimi.Location = new System.Drawing.Point(524, 32);
            this.labelTekijasnimi.Name = "labelTekijasnimi";
            this.labelTekijasnimi.Size = new System.Drawing.Size(151, 24);
            this.labelTekijasnimi.TabIndex = 5;
            this.labelTekijasnimi.Text = "Tekijän sukunimi";
            // 
            // buttonTallennaKirja
            // 
            this.buttonTallennaKirja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTallennaKirja.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonTallennaKirja.FlatAppearance.BorderSize = 0;
            this.buttonTallennaKirja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTallennaKirja.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTallennaKirja.ForeColor = System.Drawing.Color.White;
            this.buttonTallennaKirja.Location = new System.Drawing.Point(829, 63);
            this.buttonTallennaKirja.Name = "buttonTallennaKirja";
            this.buttonTallennaKirja.Size = new System.Drawing.Size(140, 48);
            this.buttonTallennaKirja.TabIndex = 10;
            this.buttonTallennaKirja.Text = "TALLENNA";
            this.buttonTallennaKirja.UseVisualStyleBackColor = false;
            this.buttonTallennaKirja.Click += new System.EventHandler(this.buttonTallennaKirja_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.buttonLisaaKirja, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonPoistaKirja, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(22, 367);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(972, 54);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // buttonLisaaKirja
            // 
            this.buttonLisaaKirja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLisaaKirja.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonLisaaKirja.FlatAppearance.BorderSize = 0;
            this.buttonLisaaKirja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLisaaKirja.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLisaaKirja.ForeColor = System.Drawing.Color.White;
            this.buttonLisaaKirja.Location = new System.Drawing.Point(3, 3);
            this.buttonLisaaKirja.Name = "buttonLisaaKirja";
            this.buttonLisaaKirja.Size = new System.Drawing.Size(140, 48);
            this.buttonLisaaKirja.TabIndex = 12;
            this.buttonLisaaKirja.Text = "Lisää Kirja";
            this.buttonLisaaKirja.UseVisualStyleBackColor = false;
            this.buttonLisaaKirja.Click += new System.EventHandler(this.buttonLisaaKirja_Click);
            // 
            // buttonPoistaKirja
            // 
            this.buttonPoistaKirja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPoistaKirja.BackColor = System.Drawing.Color.Gray;
            this.buttonPoistaKirja.FlatAppearance.BorderSize = 0;
            this.buttonPoistaKirja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPoistaKirja.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPoistaKirja.ForeColor = System.Drawing.Color.White;
            this.buttonPoistaKirja.Location = new System.Drawing.Point(829, 3);
            this.buttonPoistaKirja.Name = "buttonPoistaKirja";
            this.buttonPoistaKirja.Size = new System.Drawing.Size(140, 48);
            this.buttonPoistaKirja.TabIndex = 11;
            this.buttonPoistaKirja.Text = "Poista Kirja";
            this.buttonPoistaKirja.UseVisualStyleBackColor = false;
            this.buttonPoistaKirja.Click += new System.EventHandler(this.buttonPoistaKirja_Click);
            // 
            // labelKirjatLOtsikko
            // 
            this.labelKirjatLOtsikko.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelKirjatLOtsikko.AutoSize = true;
            this.labelKirjatLOtsikko.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKirjatLOtsikko.Location = new System.Drawing.Point(3, 18);
            this.labelKirjatLOtsikko.Name = "labelKirjatLOtsikko";
            this.labelKirjatLOtsikko.Size = new System.Drawing.Size(90, 36);
            this.labelKirjatLOtsikko.TabIndex = 3;
            this.labelKirjatLOtsikko.Text = "Kirjat";
            // 
            // Kirjat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1043, 569);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1043, 569);
            this.Name = "Kirjat";
            this.Text = "Kirjat";
            this.Load += new System.EventHandler(this.Kirjat_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKirjat)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHae)).EndInit();
            this.tableLayoutPanelLisaaKirja.ResumeLayout(false);
            this.tableLayoutPanelLisaaKirja.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewKirjat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBoxHae;
        private System.Windows.Forms.TextBox textBoxHaku;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLisaaKirja;
        private System.Windows.Forms.TextBox textBoxKnimi;
        private System.Windows.Forms.Label labelKirjannimi;
        private System.Windows.Forms.TextBox textBoxTekijaenimi;
        private System.Windows.Forms.Label labelTekijaenimi;
        private System.Windows.Forms.TextBox textBoxTekijasnimi;
        private System.Windows.Forms.Label labelTekijasnimi;
        private System.Windows.Forms.Button buttonTallennaKirja;
        private System.Windows.Forms.Button buttonPoistaKirja;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonLisaaKirja;
        private System.Windows.Forms.Label labelKirjatLOtsikko;
    }
}