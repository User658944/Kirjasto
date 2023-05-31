
namespace Kirjasto
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelKirjasto = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAsetukset = new System.Windows.Forms.Button();
            this.buttonSulje = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonKirjat = new System.Windows.Forms.Button();
            this.buttonAsiakkaat = new System.Windows.Forms.Button();
            this.buttonPalauta = new System.Windows.Forms.Button();
            this.buttonLainaa = new System.Windows.Forms.Button();
            this.buttonLainaukset = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelKirjasto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 85);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Kirjasto.Properties.Resources.KirjastoLogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelKirjasto
            // 
            this.labelKirjasto.AutoSize = true;
            this.labelKirjasto.Font = new System.Drawing.Font("Broadway", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKirjasto.ForeColor = System.Drawing.Color.White;
            this.labelKirjasto.Location = new System.Drawing.Point(75, 12);
            this.labelKirjasto.Name = "labelKirjasto";
            this.labelKirjasto.Size = new System.Drawing.Size(204, 48);
            this.labelKirjasto.TabIndex = 0;
            this.labelKirjasto.Text = "Kirjasto";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 588);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.buttonAsetukset, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSulje, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(31, 414);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(182, 129);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonAsetukset
            // 
            this.buttonAsetukset.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonAsetukset.FlatAppearance.BorderSize = 0;
            this.buttonAsetukset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAsetukset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAsetukset.Location = new System.Drawing.Point(3, 3);
            this.buttonAsetukset.Name = "buttonAsetukset";
            this.buttonAsetukset.Size = new System.Drawing.Size(167, 44);
            this.buttonAsetukset.TabIndex = 3;
            this.buttonAsetukset.Text = "      Asetukset";
            this.buttonAsetukset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAsetukset.UseVisualStyleBackColor = false;
            this.buttonAsetukset.Click += new System.EventHandler(this.buttonAsetukset_Click);
            // 
            // buttonSulje
            // 
            this.buttonSulje.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSulje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSulje.FlatAppearance.BorderSize = 0;
            this.buttonSulje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSulje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSulje.Location = new System.Drawing.Point(3, 53);
            this.buttonSulje.Name = "buttonSulje";
            this.buttonSulje.Size = new System.Drawing.Size(167, 44);
            this.buttonSulje.TabIndex = 4;
            this.buttonSulje.Text = "      Sulje";
            this.buttonSulje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSulje.UseVisualStyleBackColor = false;
            this.buttonSulje.Click += new System.EventHandler(this.buttonSulje_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonKirjat, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonAsiakkaat, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonPalauta, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonLainaa, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonLainaukset, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(31, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(182, 331);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonKirjat
            // 
            this.buttonKirjat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonKirjat.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonKirjat.FlatAppearance.BorderSize = 0;
            this.buttonKirjat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKirjat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKirjat.Location = new System.Drawing.Point(3, 243);
            this.buttonKirjat.Name = "buttonKirjat";
            this.buttonKirjat.Size = new System.Drawing.Size(167, 54);
            this.buttonKirjat.TabIndex = 4;
            this.buttonKirjat.Text = "      Kirjat";
            this.buttonKirjat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKirjat.UseVisualStyleBackColor = false;
            this.buttonKirjat.Click += new System.EventHandler(this.buttonKirjat_Click);
            // 
            // buttonAsiakkaat
            // 
            this.buttonAsiakkaat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAsiakkaat.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonAsiakkaat.FlatAppearance.BorderSize = 0;
            this.buttonAsiakkaat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAsiakkaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAsiakkaat.Location = new System.Drawing.Point(3, 183);
            this.buttonAsiakkaat.Name = "buttonAsiakkaat";
            this.buttonAsiakkaat.Size = new System.Drawing.Size(167, 54);
            this.buttonAsiakkaat.TabIndex = 3;
            this.buttonAsiakkaat.Text = "      Asiakkaat";
            this.buttonAsiakkaat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAsiakkaat.UseVisualStyleBackColor = false;
            this.buttonAsiakkaat.Click += new System.EventHandler(this.buttonAsiakkaat_Click);
            // 
            // buttonPalauta
            // 
            this.buttonPalauta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPalauta.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonPalauta.FlatAppearance.BorderSize = 0;
            this.buttonPalauta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPalauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPalauta.Location = new System.Drawing.Point(3, 123);
            this.buttonPalauta.Name = "buttonPalauta";
            this.buttonPalauta.Size = new System.Drawing.Size(167, 54);
            this.buttonPalauta.TabIndex = 2;
            this.buttonPalauta.Text = "      Palauta";
            this.buttonPalauta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPalauta.UseVisualStyleBackColor = false;
            this.buttonPalauta.Click += new System.EventHandler(this.buttonPalauta_Click);
            // 
            // buttonLainaa
            // 
            this.buttonLainaa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLainaa.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonLainaa.FlatAppearance.BorderSize = 0;
            this.buttonLainaa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLainaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLainaa.Location = new System.Drawing.Point(3, 63);
            this.buttonLainaa.Name = "buttonLainaa";
            this.buttonLainaa.Size = new System.Drawing.Size(167, 54);
            this.buttonLainaa.TabIndex = 1;
            this.buttonLainaa.Text = "      Lainaa";
            this.buttonLainaa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLainaa.UseVisualStyleBackColor = false;
            this.buttonLainaa.Click += new System.EventHandler(this.buttonLainaa_Click);
            // 
            // buttonLainaukset
            // 
            this.buttonLainaukset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLainaukset.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonLainaukset.FlatAppearance.BorderSize = 0;
            this.buttonLainaukset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLainaukset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLainaukset.Location = new System.Drawing.Point(3, 3);
            this.buttonLainaukset.Name = "buttonLainaukset";
            this.buttonLainaukset.Size = new System.Drawing.Size(167, 54);
            this.buttonLainaukset.TabIndex = 0;
            this.buttonLainaukset.Text = "      Lainaushistoria";
            this.buttonLainaukset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLainaukset.UseVisualStyleBackColor = false;
            this.buttonLainaukset.Click += new System.EventHandler(this.buttonLainaukset_Click);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Location = new System.Drawing.Point(207, 92);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1043, 569);
            this.panelMain.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kirjasto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelKirjasto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonAsetukset;
        private System.Windows.Forms.Button buttonSulje;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonKirjat;
        private System.Windows.Forms.Button buttonAsiakkaat;
        private System.Windows.Forms.Button buttonPalauta;
        private System.Windows.Forms.Button buttonLainaa;
        private System.Windows.Forms.Button buttonLainaukset;
        private System.Windows.Forms.Panel panelMain;
    }
}

