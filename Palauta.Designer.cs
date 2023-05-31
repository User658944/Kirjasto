
namespace Kirjasto
{
    partial class Palauta
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
            this.dataGridViewKirjat = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelKirjatLainassaOtsikko = new System.Windows.Forms.Label();
            this.pictureBoxHae = new System.Windows.Forms.PictureBox();
            this.textBoxHakuKirjat = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPalautaKirja = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKirjat)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHae)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1019, 545);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewKirjat, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1013, 479);
            this.tableLayoutPanel2.TabIndex = 0;
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
            this.dataGridViewKirjat.Location = new System.Drawing.Point(3, 63);
            this.dataGridViewKirjat.MultiSelect = false;
            this.dataGridViewKirjat.Name = "dataGridViewKirjat";
            this.dataGridViewKirjat.ReadOnly = true;
            this.dataGridViewKirjat.RowHeadersVisible = false;
            this.dataGridViewKirjat.RowHeadersWidth = 51;
            this.dataGridViewKirjat.RowTemplate.Height = 24;
            this.dataGridViewKirjat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKirjat.Size = new System.Drawing.Size(1007, 413);
            this.dataGridViewKirjat.TabIndex = 7;
            this.dataGridViewKirjat.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKirjat_CellEnter);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.04459F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.95541F));
            this.tableLayoutPanel3.Controls.Add(this.labelKirjatLainassaOtsikko, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxHae, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxHakuKirjat, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1007, 54);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // labelKirjatLainassaOtsikko
            // 
            this.labelKirjatLainassaOtsikko.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelKirjatLainassaOtsikko.AutoSize = true;
            this.labelKirjatLainassaOtsikko.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKirjatLainassaOtsikko.Location = new System.Drawing.Point(3, 18);
            this.labelKirjatLainassaOtsikko.Name = "labelKirjatLainassaOtsikko";
            this.labelKirjatLainassaOtsikko.Size = new System.Drawing.Size(276, 36);
            this.labelKirjatLainassaOtsikko.TabIndex = 4;
            this.labelKirjatLainassaOtsikko.Text = "Palautettavat kirjat";
            // 
            // pictureBoxHae
            // 
            this.pictureBoxHae.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxHae.BackgroundImage = global::Kirjasto.Properties.Resources.hakuGray;
            this.pictureBoxHae.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxHae.Location = new System.Drawing.Point(472, 3);
            this.pictureBoxHae.Name = "pictureBoxHae";
            this.pictureBoxHae.Size = new System.Drawing.Size(44, 48);
            this.pictureBoxHae.TabIndex = 0;
            this.pictureBoxHae.TabStop = false;
            // 
            // textBoxHakuKirjat
            // 
            this.textBoxHakuKirjat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHakuKirjat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHakuKirjat.Location = new System.Drawing.Point(522, 13);
            this.textBoxHakuKirjat.Name = "textBoxHakuKirjat";
            this.textBoxHakuKirjat.Size = new System.Drawing.Size(482, 38);
            this.textBoxHakuKirjat.TabIndex = 1;
            this.textBoxHakuKirjat.TextChanged += new System.EventHandler(this.textBoxHakuKirjat_TextChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.buttonPalautaKirja, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 488);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1013, 54);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // buttonPalautaKirja
            // 
            this.buttonPalautaKirja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPalautaKirja.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonPalautaKirja.FlatAppearance.BorderSize = 0;
            this.buttonPalautaKirja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPalautaKirja.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPalautaKirja.ForeColor = System.Drawing.Color.White;
            this.buttonPalautaKirja.Location = new System.Drawing.Point(790, 3);
            this.buttonPalautaKirja.Name = "buttonPalautaKirja";
            this.buttonPalautaKirja.Size = new System.Drawing.Size(220, 48);
            this.buttonPalautaKirja.TabIndex = 13;
            this.buttonPalautaKirja.Text = "Palauta Kirja";
            this.buttonPalautaKirja.UseVisualStyleBackColor = false;
            this.buttonPalautaKirja.Click += new System.EventHandler(this.buttonPalautaKirja_Click);
            // 
            // Palauta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1043, 569);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1043, 569);
            this.Name = "Palauta";
            this.Text = "Palauta";
            this.Load += new System.EventHandler(this.Palauta_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKirjat)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHae)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelKirjatLainassaOtsikko;
        private System.Windows.Forms.PictureBox pictureBoxHae;
        private System.Windows.Forms.TextBox textBoxHakuKirjat;
        private System.Windows.Forms.DataGridView dataGridViewKirjat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button buttonPalautaKirja;
    }
}