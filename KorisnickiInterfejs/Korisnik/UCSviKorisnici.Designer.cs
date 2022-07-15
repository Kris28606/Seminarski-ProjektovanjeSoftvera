using System.Windows.Forms;

namespace KorisnickiInterfejs.Korisnik
{
    partial class UCSviKorisnici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSviKorisnici));
            this.gbKorisnici = new System.Windows.Forms.GroupBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.gbKorisnici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKorisnici
            // 
            this.gbKorisnici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbKorisnici.BackColor = System.Drawing.Color.MistyRose;
            this.gbKorisnici.Controls.Add(this.btnPrikazi);
            this.gbKorisnici.Controls.Add(this.txtPretraga);
            this.gbKorisnici.Controls.Add(this.lblPretraga);
            this.gbKorisnici.Controls.Add(this.dgvKorisnici);
            this.gbKorisnici.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbKorisnici.Location = new System.Drawing.Point(47, 74);
            this.gbKorisnici.Name = "gbKorisnici";
            this.gbKorisnici.Size = new System.Drawing.Size(661, 378);
            this.gbKorisnici.TabIndex = 0;
            this.gbKorisnici.TabStop = false;
            this.gbKorisnici.Text = "Korisnici";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikazi.BackColor = System.Drawing.Color.LightSalmon;
            this.btnPrikazi.Location = new System.Drawing.Point(457, 44);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(98, 36);
            this.btnPrikazi.TabIndex = 8;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPretraga.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPretraga.Location = new System.Drawing.Point(201, 51);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(226, 26);
            this.txtPretraga.TabIndex = 6;
            this.txtPretraga.Text = "Unesite kriterijum";
            this.txtPretraga.Click += new System.EventHandler(this.txtPretraga_Click);
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // lblPretraga
            // 
            this.lblPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretraga.Location = new System.Drawing.Point(106, 51);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(76, 20);
            this.lblPretraga.TabIndex = 5;
            this.lblPretraga.Text = "Pretraga:";
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Location = new System.Drawing.Point(56, 101);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.ReadOnly = true;
            this.dgvKorisnici.Size = new System.Drawing.Size(546, 238);
            this.dgvKorisnici.TabIndex = 0;
            // 
            // UCSviKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.gbKorisnici);
            this.Name = "UCSviKorisnici";
            this.Size = new System.Drawing.Size(760, 533);
            this.gbKorisnici.ResumeLayout(false);
            this.gbKorisnici.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKorisnici;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label lblPretraga;

        public GroupBox GbKorisnici { get => gbKorisnici; set => gbKorisnici = value; }
        public DataGridView DgvKorisnici { get => dgvKorisnici; set => dgvKorisnici = value; }
        public Button BtnPrikazi { get => btnPrikazi; set => btnPrikazi = value; }
        public TextBox TxtPretraga { get => txtPretraga; set => txtPretraga = value; }
        public Label LblPretraga { get => lblPretraga; set => lblPretraga = value; }
    }
}
