using System.Windows.Forms;

namespace KorisnickiInterfejs.Faktura
{
    partial class UCSveFakture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSveFakture));
            this.dgvFakture = new System.Windows.Forms.DataGridView();
            this.lblGreska = new System.Windows.Forms.Label();
            this.lblDatumGreska = new System.Windows.Forms.Label();
            this.gbFaktura = new System.Windows.Forms.GroupBox();
            this.btnStorniraj = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblPretraga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFakture)).BeginInit();
            this.gbFaktura.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFakture
            // 
            this.dgvFakture.AllowUserToAddRows = false;
            this.dgvFakture.AllowUserToDeleteRows = false;
            this.dgvFakture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFakture.Location = new System.Drawing.Point(128, 109);
            this.dgvFakture.Name = "dgvFakture";
            this.dgvFakture.ReadOnly = true;
            this.dgvFakture.Size = new System.Drawing.Size(604, 268);
            this.dgvFakture.TabIndex = 11;
            // 
            // lblGreska
            // 
            this.lblGreska.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGreska.AutoSize = true;
            this.lblGreska.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreska.ForeColor = System.Drawing.Color.Red;
            this.lblGreska.Location = new System.Drawing.Point(27, 210);
            this.lblGreska.Name = "lblGreska";
            this.lblGreska.Size = new System.Drawing.Size(0, 14);
            this.lblGreska.TabIndex = 13;
            // 
            // lblDatumGreska
            // 
            this.lblDatumGreska.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatumGreska.AutoSize = true;
            this.lblDatumGreska.ForeColor = System.Drawing.Color.Red;
            this.lblDatumGreska.Location = new System.Drawing.Point(328, 132);
            this.lblDatumGreska.Name = "lblDatumGreska";
            this.lblDatumGreska.Size = new System.Drawing.Size(0, 16);
            this.lblDatumGreska.TabIndex = 14;
            // 
            // gbFaktura
            // 
            this.gbFaktura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbFaktura.BackColor = System.Drawing.Color.Thistle;
            this.gbFaktura.Controls.Add(this.btnStorniraj);
            this.gbFaktura.Controls.Add(this.txtPretraga);
            this.gbFaktura.Controls.Add(this.lblPretraga);
            this.gbFaktura.Controls.Add(this.lblDatumGreska);
            this.gbFaktura.Controls.Add(this.lblGreska);
            this.gbFaktura.Controls.Add(this.dgvFakture);
            this.gbFaktura.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFaktura.Location = new System.Drawing.Point(130, 129);
            this.gbFaktura.Name = "gbFaktura";
            this.gbFaktura.Size = new System.Drawing.Size(850, 424);
            this.gbFaktura.TabIndex = 5;
            this.gbFaktura.TabStop = false;
            this.gbFaktura.Text = "Fakture";
            // 
            // btnStorniraj
            // 
            this.btnStorniraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStorniraj.BackColor = System.Drawing.Color.Violet;
            this.btnStorniraj.Location = new System.Drawing.Point(555, 61);
            this.btnStorniraj.Name = "btnStorniraj";
            this.btnStorniraj.Size = new System.Drawing.Size(98, 36);
            this.btnStorniraj.TabIndex = 18;
            this.btnStorniraj.Text = "Prikazi";
            this.btnStorniraj.UseVisualStyleBackColor = false;
            this.btnStorniraj.Click += new System.EventHandler(this.btnStorniraj_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPretraga.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPretraga.Location = new System.Drawing.Point(278, 68);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(226, 26);
            this.txtPretraga.TabIndex = 16;
            this.txtPretraga.Text = "Unesite kriterijum";
            this.txtPretraga.Click += new System.EventHandler(this.txtPretraga_Click);
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // lblPretraga
            // 
            this.lblPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretraga.Location = new System.Drawing.Point(183, 68);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(76, 20);
            this.lblPretraga.TabIndex = 15;
            this.lblPretraga.Text = "Pretraga:";
            // 
            // UCSveFakture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.gbFaktura);
            this.DoubleBuffered = true;
            this.Name = "UCSveFakture";
            this.Size = new System.Drawing.Size(1100, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFakture)).EndInit();
            this.gbFaktura.ResumeLayout(false);
            this.gbFaktura.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFakture;
        private System.Windows.Forms.Label lblGreska;
        private System.Windows.Forms.Label lblDatumGreska;
        private System.Windows.Forms.GroupBox gbFaktura;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.Button btnStorniraj;

        public DataGridView DgvFakture { get => dgvFakture; set => dgvFakture = value; }
        public Label LblGreska { get => lblGreska; set => lblGreska = value; }
        public Label LblDatumGreska { get => lblDatumGreska; set => lblDatumGreska = value; }
        public GroupBox GbFaktura { get => gbFaktura; set => gbFaktura = value; }
        public TextBox TxtPretraga { get => txtPretraga; set => txtPretraga = value; }
        public Label LblPretraga { get => lblPretraga; set => lblPretraga = value; }
        public Button BtnStorniraj { get => btnStorniraj; set => btnStorniraj = value; }
    }
}
