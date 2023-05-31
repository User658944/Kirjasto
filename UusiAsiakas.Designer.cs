
namespace Kirjasto
{
    partial class UusiAsiakas
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
            this.buttonTallenna = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelEtunimi = new System.Windows.Forms.Label();
            this.textBoxEnimi = new System.Windows.Forms.TextBox();
            this.textBoxIdasiakkaat = new System.Windows.Forms.TextBox();
            this.labelAsiakasid = new System.Windows.Forms.Label();
            this.labelSukunimi = new System.Windows.Forms.Label();
            this.textBoxSnimi = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPuhnro = new System.Windows.Forms.Label();
            this.textBoxSposti = new System.Windows.Forms.TextBox();
            this.labelSposti = new System.Windows.Forms.Label();
            this.textBoxPuhnro = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTakaisin = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1019, 545);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonTallenna
            // 
            this.buttonTallenna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTallenna.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonTallenna.FlatAppearance.BorderSize = 0;
            this.buttonTallenna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTallenna.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTallenna.ForeColor = System.Drawing.Color.White;
            this.buttonTallenna.Location = new System.Drawing.Point(243, 3);
            this.buttonTallenna.Name = "buttonTallenna";
            this.buttonTallenna.Size = new System.Drawing.Size(200, 48);
            this.buttonTallenna.TabIndex = 0;
            this.buttonTallenna.Text = "TALLENNA";
            this.buttonTallenna.UseVisualStyleBackColor = false;
            this.buttonTallenna.Click += new System.EventHandler(this.buttonTallenna_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.labelEtunimi, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxEnimi, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxIdasiakkaat, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelAsiakasid, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelSukunimi, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxSnimi, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(63, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(893, 114);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // labelEtunimi
            // 
            this.labelEtunimi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEtunimi.AutoSize = true;
            this.labelEtunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEtunimi.Location = new System.Drawing.Point(3, 32);
            this.labelEtunimi.Name = "labelEtunimi";
            this.labelEtunimi.Size = new System.Drawing.Size(76, 25);
            this.labelEtunimi.TabIndex = 2;
            this.labelEtunimi.Text = "Etunimi";
            // 
            // textBoxEnimi
            // 
            this.textBoxEnimi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEnimi.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnimi.Location = new System.Drawing.Point(3, 60);
            this.textBoxEnimi.Name = "textBoxEnimi";
            this.textBoxEnimi.Size = new System.Drawing.Size(278, 44);
            this.textBoxEnimi.TabIndex = 3;
            this.textBoxEnimi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEnimi_KeyPress);
            this.textBoxEnimi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxEnimi_KeyUp);
            // 
            // textBoxIdasiakkaat
            // 
            this.textBoxIdasiakkaat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIdasiakkaat.Enabled = false;
            this.textBoxIdasiakkaat.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdasiakkaat.Location = new System.Drawing.Point(611, 60);
            this.textBoxIdasiakkaat.Name = "textBoxIdasiakkaat";
            this.textBoxIdasiakkaat.Size = new System.Drawing.Size(279, 44);
            this.textBoxIdasiakkaat.TabIndex = 0;
            this.textBoxIdasiakkaat.Text = "AS100000";
            // 
            // labelAsiakasid
            // 
            this.labelAsiakasid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAsiakasid.AutoSize = true;
            this.labelAsiakasid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsiakasid.Location = new System.Drawing.Point(611, 32);
            this.labelAsiakasid.Name = "labelAsiakasid";
            this.labelAsiakasid.Size = new System.Drawing.Size(106, 25);
            this.labelAsiakasid.TabIndex = 2;
            this.labelAsiakasid.Text = "Asiakas ID";
            // 
            // labelSukunimi
            // 
            this.labelSukunimi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSukunimi.AutoSize = true;
            this.labelSukunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSukunimi.Location = new System.Drawing.Point(307, 32);
            this.labelSukunimi.Name = "labelSukunimi";
            this.labelSukunimi.Size = new System.Drawing.Size(93, 25);
            this.labelSukunimi.TabIndex = 1;
            this.labelSukunimi.Text = "Sukunimi";
            // 
            // textBoxSnimi
            // 
            this.textBoxSnimi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSnimi.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSnimi.Location = new System.Drawing.Point(307, 60);
            this.textBoxSnimi.Name = "textBoxSnimi";
            this.textBoxSnimi.Size = new System.Drawing.Size(278, 44);
            this.textBoxSnimi.TabIndex = 4;
            this.textBoxSnimi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSnimi_KeyPress);
            this.textBoxSnimi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSnimi_KeyUp);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.labelPuhnro, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxSposti, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.labelSposti, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBoxPuhnro, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(63, 169);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(893, 234);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // labelPuhnro
            // 
            this.labelPuhnro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPuhnro.AutoSize = true;
            this.labelPuhnro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuhnro.Location = new System.Drawing.Point(3, 33);
            this.labelPuhnro.Name = "labelPuhnro";
            this.labelPuhnro.Size = new System.Drawing.Size(118, 25);
            this.labelPuhnro.TabIndex = 0;
            this.labelPuhnro.Text = "Puh numero";
            // 
            // textBoxSposti
            // 
            this.textBoxSposti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSposti.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSposti.Location = new System.Drawing.Point(3, 177);
            this.textBoxSposti.Name = "textBoxSposti";
            this.textBoxSposti.Size = new System.Drawing.Size(440, 44);
            this.textBoxSposti.TabIndex = 6;
            this.textBoxSposti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSposti_KeyPress);
            this.textBoxSposti.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSposti_KeyUp);
            // 
            // labelSposti
            // 
            this.labelSposti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSposti.AutoSize = true;
            this.labelSposti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSposti.Location = new System.Drawing.Point(3, 149);
            this.labelSposti.Name = "labelSposti";
            this.labelSposti.Size = new System.Drawing.Size(110, 25);
            this.labelSposti.TabIndex = 1;
            this.labelSposti.Text = "Sähköposti";
            // 
            // textBoxPuhnro
            // 
            this.textBoxPuhnro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPuhnro.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPuhnro.Location = new System.Drawing.Point(3, 61);
            this.textBoxPuhnro.Name = "textBoxPuhnro";
            this.textBoxPuhnro.Size = new System.Drawing.Size(440, 44);
            this.textBoxPuhnro.TabIndex = 5;
            this.textBoxPuhnro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPuhnro_KeyPress);
            this.textBoxPuhnro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPuhnro_KeyUp);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.buttonTakaisin, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonTallenna, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(63, 435);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(893, 54);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // buttonTakaisin
            // 
            this.buttonTakaisin.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonTakaisin.FlatAppearance.BorderSize = 0;
            this.buttonTakaisin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTakaisin.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTakaisin.ForeColor = System.Drawing.Color.White;
            this.buttonTakaisin.Location = new System.Drawing.Point(3, 3);
            this.buttonTakaisin.Name = "buttonTakaisin";
            this.buttonTakaisin.Size = new System.Drawing.Size(200, 48);
            this.buttonTakaisin.TabIndex = 1;
            this.buttonTakaisin.Text = "Takaisin";
            this.buttonTakaisin.UseVisualStyleBackColor = false;
            this.buttonTakaisin.Click += new System.EventHandler(this.buttonTakaisin_Click);
            // 
            // UusiAsiakas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1043, 569);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1043, 569);
            this.Name = "UusiAsiakas";
            this.Text = "UusiAsiakas";
            this.Load += new System.EventHandler(this.UusiAsiakas_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelEtunimi;
        private System.Windows.Forms.TextBox textBoxIdasiakkaat;
        private System.Windows.Forms.TextBox textBoxSnimi;
        private System.Windows.Forms.Label labelAsiakasid;
        private System.Windows.Forms.Label labelSukunimi;
        private System.Windows.Forms.TextBox textBoxEnimi;
        private System.Windows.Forms.Label labelPuhnro;
        private System.Windows.Forms.TextBox textBoxPuhnro;
        private System.Windows.Forms.Label labelSposti;
        private System.Windows.Forms.TextBox textBoxSposti;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonTallenna;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button buttonTakaisin;
    }
}