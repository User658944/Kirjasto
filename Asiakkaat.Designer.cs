
namespace Kirjasto
{
    partial class Asiakkaat
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxHae = new System.Windows.Forms.PictureBox();
            this.textBoxHaku = new System.Windows.Forms.TextBox();
            this.buttonUusiAsiakas = new System.Windows.Forms.Button();
            this.dataGridViewAsiakkaat = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelKortti = new System.Windows.Forms.TableLayoutPanel();
            this.labelNimi = new System.Windows.Forms.Label();
            this.labelSposti = new System.Windows.Forms.Label();
            this.labelPuhnum = new System.Windows.Forms.Label();
            this.labelIdasiakkaat = new System.Windows.Forms.Label();
            this.labelKirjasto = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPoistaAsiakas = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHae)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsiakkaat)).BeginInit();
            this.tableLayoutPanelKortti.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewAsiakkaat, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1019, 545);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxHae, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxHaku, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonUusiAsiakas, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(573, 54);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBoxHae
            // 
            this.pictureBoxHae.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxHae.BackgroundImage = global::Kirjasto.Properties.Resources.hakuGray;
            this.pictureBoxHae.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxHae.Location = new System.Drawing.Point(293, 3);
            this.pictureBoxHae.Name = "pictureBoxHae";
            this.pictureBoxHae.Size = new System.Drawing.Size(54, 48);
            this.pictureBoxHae.TabIndex = 0;
            this.pictureBoxHae.TabStop = false;
            // 
            // textBoxHaku
            // 
            this.textBoxHaku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHaku.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHaku.Location = new System.Drawing.Point(353, 8);
            this.textBoxHaku.Name = "textBoxHaku";
            this.textBoxHaku.Size = new System.Drawing.Size(217, 38);
            this.textBoxHaku.TabIndex = 1;
            this.textBoxHaku.TextChanged += new System.EventHandler(this.textBoxHaku_TextChanged);
            // 
            // buttonUusiAsiakas
            // 
            this.buttonUusiAsiakas.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonUusiAsiakas.FlatAppearance.BorderSize = 0;
            this.buttonUusiAsiakas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUusiAsiakas.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUusiAsiakas.ForeColor = System.Drawing.Color.White;
            this.buttonUusiAsiakas.Location = new System.Drawing.Point(3, 3);
            this.buttonUusiAsiakas.Name = "buttonUusiAsiakas";
            this.buttonUusiAsiakas.Size = new System.Drawing.Size(200, 48);
            this.buttonUusiAsiakas.TabIndex = 2;
            this.buttonUusiAsiakas.Text = "Uusi Asiakas";
            this.buttonUusiAsiakas.UseVisualStyleBackColor = false;
            this.buttonUusiAsiakas.Click += new System.EventHandler(this.buttonUusiAsiakas_Click);
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
            this.dataGridViewAsiakkaat.Location = new System.Drawing.Point(13, 63);
            this.dataGridViewAsiakkaat.MultiSelect = false;
            this.dataGridViewAsiakkaat.Name = "dataGridViewAsiakkaat";
            this.dataGridViewAsiakkaat.ReadOnly = true;
            this.dataGridViewAsiakkaat.RowHeadersVisible = false;
            this.dataGridViewAsiakkaat.RowHeadersWidth = 51;
            this.dataGridViewAsiakkaat.RowTemplate.Height = 24;
            this.dataGridViewAsiakkaat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAsiakkaat.Size = new System.Drawing.Size(573, 419);
            this.dataGridViewAsiakkaat.TabIndex = 1;
            this.dataGridViewAsiakkaat.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAsiakkaat_CellEnter);
            // 
            // tableLayoutPanelKortti
            // 
            this.tableLayoutPanelKortti.BackgroundImage = global::Kirjasto.Properties.Resources.kortti1;
            this.tableLayoutPanelKortti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanelKortti.ColumnCount = 3;
            this.tableLayoutPanelKortti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelKortti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelKortti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelKortti.Controls.Add(this.labelNimi, 1, 4);
            this.tableLayoutPanelKortti.Controls.Add(this.labelSposti, 1, 5);
            this.tableLayoutPanelKortti.Controls.Add(this.labelPuhnum, 1, 6);
            this.tableLayoutPanelKortti.Controls.Add(this.labelIdasiakkaat, 1, 7);
            this.tableLayoutPanelKortti.Controls.Add(this.labelKirjasto, 1, 1);
            this.tableLayoutPanelKortti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelKortti.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelKortti.Name = "tableLayoutPanelKortti";
            this.tableLayoutPanelKortti.RowCount = 9;
            this.tableLayoutPanelKortti.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanelKortti.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelKortti.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelKortti.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelKortti.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelKortti.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelKortti.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelKortti.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanelKortti.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanelKortti.Size = new System.Drawing.Size(388, 244);
            this.tableLayoutPanelKortti.TabIndex = 2;
            // 
            // labelNimi
            // 
            this.labelNimi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNimi.AutoSize = true;
            this.labelNimi.BackColor = System.Drawing.Color.Transparent;
            this.labelNimi.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNimi.ForeColor = System.Drawing.Color.White;
            this.labelNimi.Location = new System.Drawing.Point(23, 106);
            this.labelNimi.Name = "labelNimi";
            this.labelNimi.Size = new System.Drawing.Size(130, 30);
            this.labelNimi.TabIndex = 1;
            this.labelNimi.Text = "Anssi Asiakas";
            // 
            // labelSposti
            // 
            this.labelSposti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSposti.AutoSize = true;
            this.labelSposti.BackColor = System.Drawing.Color.Transparent;
            this.labelSposti.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSposti.ForeColor = System.Drawing.Color.White;
            this.labelSposti.Location = new System.Drawing.Point(23, 137);
            this.labelSposti.Name = "labelSposti";
            this.labelSposti.Size = new System.Drawing.Size(139, 30);
            this.labelSposti.TabIndex = 2;
            this.labelSposti.Text = "sposti@posti.fi";
            // 
            // labelPuhnum
            // 
            this.labelPuhnum.AutoSize = true;
            this.labelPuhnum.BackColor = System.Drawing.Color.Transparent;
            this.labelPuhnum.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuhnum.ForeColor = System.Drawing.Color.White;
            this.labelPuhnum.Location = new System.Drawing.Point(23, 167);
            this.labelPuhnum.Name = "labelPuhnum";
            this.labelPuhnum.Size = new System.Drawing.Size(137, 30);
            this.labelPuhnum.TabIndex = 4;
            this.labelPuhnum.Text = "040 1234567";
            // 
            // labelIdasiakkaat
            // 
            this.labelIdasiakkaat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIdasiakkaat.AutoSize = true;
            this.labelIdasiakkaat.BackColor = System.Drawing.Color.Transparent;
            this.labelIdasiakkaat.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdasiakkaat.ForeColor = System.Drawing.Color.White;
            this.labelIdasiakkaat.Location = new System.Drawing.Point(256, 198);
            this.labelIdasiakkaat.Name = "labelIdasiakkaat";
            this.labelIdasiakkaat.Size = new System.Drawing.Size(109, 30);
            this.labelIdasiakkaat.TabIndex = 0;
            this.labelIdasiakkaat.Text = "AS100000";
            // 
            // labelKirjasto
            // 
            this.labelKirjasto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKirjasto.AutoSize = true;
            this.labelKirjasto.BackColor = System.Drawing.Color.Transparent;
            this.labelKirjasto.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKirjasto.ForeColor = System.Drawing.Color.White;
            this.labelKirjasto.Location = new System.Drawing.Point(187, 13);
            this.labelKirjasto.Name = "labelKirjasto";
            this.labelKirjasto.Size = new System.Drawing.Size(178, 30);
            this.labelKirjasto.TabIndex = 3;
            this.labelKirjasto.Text = "Kaupungin Kirjasto";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanelKortti, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonPoistaAsiakas, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(612, 63);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(394, 419);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // buttonPoistaAsiakas
            // 
            this.buttonPoistaAsiakas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPoistaAsiakas.BackColor = System.Drawing.Color.Gray;
            this.buttonPoistaAsiakas.FlatAppearance.BorderSize = 0;
            this.buttonPoistaAsiakas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPoistaAsiakas.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPoistaAsiakas.ForeColor = System.Drawing.Color.White;
            this.buttonPoistaAsiakas.Location = new System.Drawing.Point(221, 253);
            this.buttonPoistaAsiakas.Name = "buttonPoistaAsiakas";
            this.buttonPoistaAsiakas.Size = new System.Drawing.Size(170, 48);
            this.buttonPoistaAsiakas.TabIndex = 3;
            this.buttonPoistaAsiakas.Text = "Poista Asiakas";
            this.buttonPoistaAsiakas.UseVisualStyleBackColor = false;
            this.buttonPoistaAsiakas.Click += new System.EventHandler(this.buttonPoistaAsiakas_Click);
            // 
            // Asiakkaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1043, 569);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1043, 569);
            this.Name = "Asiakkaat";
            this.Text = "Asiakkaat";
            this.Load += new System.EventHandler(this.Asiakkaat_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHae)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsiakkaat)).EndInit();
            this.tableLayoutPanelKortti.ResumeLayout(false);
            this.tableLayoutPanelKortti.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridViewAsiakkaat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelKortti;
        private System.Windows.Forms.Label labelIdasiakkaat;
        private System.Windows.Forms.Label labelNimi;
        private System.Windows.Forms.Label labelKirjasto;
        private System.Windows.Forms.Label labelSposti;
        private System.Windows.Forms.Label labelPuhnum;
        private System.Windows.Forms.PictureBox pictureBoxHae;
        private System.Windows.Forms.TextBox textBoxHaku;
        private System.Windows.Forms.Button buttonUusiAsiakas;
        private System.Windows.Forms.Button buttonPoistaAsiakas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}