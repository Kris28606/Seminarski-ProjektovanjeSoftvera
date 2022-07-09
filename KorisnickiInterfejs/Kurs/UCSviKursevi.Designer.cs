using System.Windows.Forms;

namespace KorisnickiInterfejs.Kurs
{
    partial class UCSviKursevi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSviKursevi));
            this.gbSviKursevi = new System.Windows.Forms.GroupBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnNadji = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.dgvKursevi = new System.Windows.Forms.DataGridView();
            this.gbSviKursevi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursevi)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSviKursevi
            // 
            this.gbSviKursevi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbSviKursevi.BackColor = System.Drawing.Color.SkyBlue;
            this.gbSviKursevi.Controls.Add(this.btnPrikazi);
            this.gbSviKursevi.Controls.Add(this.btnNadji);
            this.gbSviKursevi.Controls.Add(this.txtPretraga);
            this.gbSviKursevi.Controls.Add(this.lblPretraga);
            this.gbSviKursevi.Controls.Add(this.dgvKursevi);
            this.gbSviKursevi.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSviKursevi.Location = new System.Drawing.Point(47, 49);
            this.gbSviKursevi.Name = "gbSviKursevi";
            this.gbSviKursevi.Size = new System.Drawing.Size(603, 468);
            this.gbSviKursevi.TabIndex = 0;
            this.gbSviKursevi.TabStop = false;
            this.gbSviKursevi.Text = "Kursevi";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikazi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPrikazi.Location = new System.Drawing.Point(434, 81);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(98, 36);
            this.btnPrikazi.TabIndex = 4;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // btnNadji
            // 
            this.btnNadji.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNadji.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNadji.Location = new System.Drawing.Point(434, 33);
            this.btnNadji.Name = "btnNadji";
            this.btnNadji.Size = new System.Drawing.Size(98, 36);
            this.btnNadji.TabIndex = 3;
            this.btnNadji.Text = "Nadji";
            this.btnNadji.UseVisualStyleBackColor = false;
            this.btnNadji.Click += new System.EventHandler(this.btnNadji_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPretraga.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPretraga.Location = new System.Drawing.Point(181, 40);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(226, 26);
            this.txtPretraga.TabIndex = 2;
            this.txtPretraga.Text = "Unesite kriterijum";
            this.txtPretraga.Click += new System.EventHandler(this.txtPretraga_Click);
            // 
            // lblPretraga
            // 
            this.lblPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretraga.Location = new System.Drawing.Point(86, 40);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(76, 20);
            this.lblPretraga.TabIndex = 1;
            this.lblPretraga.Text = "Pretraga:";
            // 
            // dgvKursevi
            // 
            this.dgvKursevi.AllowUserToAddRows = false;
            this.dgvKursevi.AllowUserToDeleteRows = false;
            this.dgvKursevi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvKursevi.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKursevi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKursevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKursevi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKursevi.GridColor = System.Drawing.Color.Lavender;
            this.dgvKursevi.Location = new System.Drawing.Point(47, 123);
            this.dgvKursevi.Name = "dgvKursevi";
            this.dgvKursevi.ReadOnly = true;
            this.dgvKursevi.Size = new System.Drawing.Size(513, 319);
            this.dgvKursevi.TabIndex = 0;
            // 
            // UCSviKursevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.gbSviKursevi);
            this.Name = "UCSviKursevi";
            this.Size = new System.Drawing.Size(705, 557);
            this.gbSviKursevi.ResumeLayout(false);
            this.gbSviKursevi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursevi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSviKursevi;
        private System.Windows.Forms.DataGridView dgvKursevi;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.Button btnNadji;
        private System.Windows.Forms.Button btnPrikazi;

        public GroupBox GbSviKursevi { get => gbSviKursevi; set => gbSviKursevi = value; }
        public DataGridView DgvKursevi { get => dgvKursevi; set => dgvKursevi = value; }
        public TextBox TxtPretraga { get => txtPretraga; set => txtPretraga = value; }
        public Label LblPretraga { get => lblPretraga; set => lblPretraga = value; }
        public Button BtnNadji { get => btnNadji; set => btnNadji = value; }
        public Button BtnPrikazi { get => btnPrikazi; set => btnPrikazi = value; }
    }
}
