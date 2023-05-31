
namespace Kirjasto
{
    partial class Lainaukset
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelKirjatLOtsikko = new System.Windows.Forms.Label();
            this.pictureBoxHae = new System.Windows.Forms.PictureBox();
            this.textBoxHakuLainaustapahtumat = new System.Windows.Forms.TextBox();
            this.dataGridViewTapahtumat = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHae)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTapahtumat)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewTapahtumat, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1019, 545);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.04459F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.95541F));
            this.tableLayoutPanel3.Controls.Add(this.labelKirjatLOtsikko, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxHae, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxHakuLainaustapahtumat, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(23, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(973, 54);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // labelKirjatLOtsikko
            // 
            this.labelKirjatLOtsikko.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelKirjatLOtsikko.AutoSize = true;
            this.labelKirjatLOtsikko.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKirjatLOtsikko.Location = new System.Drawing.Point(3, 18);
            this.labelKirjatLOtsikko.Name = "labelKirjatLOtsikko";
            this.labelKirjatLOtsikko.Size = new System.Drawing.Size(279, 36);
            this.labelKirjatLOtsikko.TabIndex = 2;
            this.labelKirjatLOtsikko.Text = "Lainaustapahtumat";
            // 
            // pictureBoxHae
            // 
            this.pictureBoxHae.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxHae.BackgroundImage = global::Kirjasto.Properties.Resources.hakuGray;
            this.pictureBoxHae.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxHae.Location = new System.Drawing.Point(455, 3);
            this.pictureBoxHae.Name = "pictureBoxHae";
            this.pictureBoxHae.Size = new System.Drawing.Size(44, 48);
            this.pictureBoxHae.TabIndex = 0;
            this.pictureBoxHae.TabStop = false;
            // 
            // textBoxHakuLainaustapahtumat
            // 
            this.textBoxHakuLainaustapahtumat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHakuLainaustapahtumat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHakuLainaustapahtumat.Location = new System.Drawing.Point(505, 13);
            this.textBoxHakuLainaustapahtumat.Name = "textBoxHakuLainaustapahtumat";
            this.textBoxHakuLainaustapahtumat.Size = new System.Drawing.Size(465, 38);
            this.textBoxHakuLainaustapahtumat.TabIndex = 2;
            this.textBoxHakuLainaustapahtumat.TextChanged += new System.EventHandler(this.textBoxHakuLainaustapahtumat_TextChanged);
            // 
            // dataGridViewTapahtumat
            // 
            this.dataGridViewTapahtumat.AllowUserToAddRows = false;
            this.dataGridViewTapahtumat.AllowUserToDeleteRows = false;
            this.dataGridViewTapahtumat.AllowUserToResizeRows = false;
            this.dataGridViewTapahtumat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTapahtumat.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewTapahtumat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTapahtumat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTapahtumat.Location = new System.Drawing.Point(23, 63);
            this.dataGridViewTapahtumat.MultiSelect = false;
            this.dataGridViewTapahtumat.Name = "dataGridViewTapahtumat";
            this.dataGridViewTapahtumat.ReadOnly = true;
            this.dataGridViewTapahtumat.RowHeadersVisible = false;
            this.dataGridViewTapahtumat.RowHeadersWidth = 51;
            this.dataGridViewTapahtumat.RowTemplate.Height = 24;
            this.dataGridViewTapahtumat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTapahtumat.Size = new System.Drawing.Size(973, 459);
            this.dataGridViewTapahtumat.TabIndex = 1;
            this.dataGridViewTapahtumat.Visible = false;
            this.dataGridViewTapahtumat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTapahtumat_CellDoubleClick);
            this.dataGridViewTapahtumat.VisibleChanged += new System.EventHandler(this.dataGridViewTapahtumat_VisibleChanged);
            // 
            // Lainaukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1043, 569);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1043, 569);
            this.Name = "Lainaukset";
            this.Text = "Lainaukset";
            this.Load += new System.EventHandler(this.Lainaukset_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHae)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTapahtumat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelKirjatLOtsikko;
        private System.Windows.Forms.PictureBox pictureBoxHae;
        private System.Windows.Forms.TextBox textBoxHakuLainaustapahtumat;
        private System.Windows.Forms.DataGridView dataGridViewTapahtumat;
    }
}