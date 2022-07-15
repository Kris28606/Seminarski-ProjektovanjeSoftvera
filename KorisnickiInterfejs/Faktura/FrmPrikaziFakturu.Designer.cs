using System.Windows.Forms;

namespace KorisnickiInterfejs.Faktura
{
    partial class FrmPrikaziFakturu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrikaziFakturu));
            this.cbKorisnik = new System.Windows.Forms.ComboBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.lblUkupnaCena = new System.Windows.Forms.Label();
            this.lblNacinPlacanja = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.txtUkupnaCena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStornirana = new System.Windows.Forms.TextBox();
            this.cbNacinPlacanja = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbKorisnik
            // 
            this.cbKorisnik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbKorisnik.Enabled = false;
            this.cbKorisnik.FormattingEnabled = true;
            this.cbKorisnik.Location = new System.Drawing.Point(253, 82);
            this.cbKorisnik.Name = "cbKorisnik";
            this.cbKorisnik.Size = new System.Drawing.Size(162, 21);
            this.cbKorisnik.TabIndex = 16;
            // 
            // txtDatum
            // 
            this.txtDatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatum.Enabled = false;
            this.txtDatum.Location = new System.Drawing.Point(253, 202);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(162, 20);
            this.txtDatum.TabIndex = 14;
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblKorisnik.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnik.Location = new System.Drawing.Point(120, 78);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(91, 23);
            this.lblKorisnik.TabIndex = 13;
            this.lblKorisnik.Text = "Korisnik:";
            // 
            // lblUkupnaCena
            // 
            this.lblUkupnaCena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUkupnaCena.AutoSize = true;
            this.lblUkupnaCena.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblUkupnaCena.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupnaCena.Location = new System.Drawing.Point(106, 260);
            this.lblUkupnaCena.Name = "lblUkupnaCena";
            this.lblUkupnaCena.Size = new System.Drawing.Size(127, 23);
            this.lblUkupnaCena.TabIndex = 12;
            this.lblUkupnaCena.Text = "Ukupna cena:";
            // 
            // lblNacinPlacanja
            // 
            this.lblNacinPlacanja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNacinPlacanja.AutoSize = true;
            this.lblNacinPlacanja.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblNacinPlacanja.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacinPlacanja.Location = new System.Drawing.Point(92, 140);
            this.lblNacinPlacanja.Name = "lblNacinPlacanja";
            this.lblNacinPlacanja.Size = new System.Drawing.Size(141, 23);
            this.lblNacinPlacanja.TabIndex = 10;
            this.lblNacinPlacanja.Text = "Nacin placanja:";
            // 
            // lblDatum
            // 
            this.lblDatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatum.AutoSize = true;
            this.lblDatum.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblDatum.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(129, 198);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(73, 23);
            this.lblDatum.TabIndex = 11;
            this.lblDatum.Text = "Datum:";
            // 
            // txtUkupnaCena
            // 
            this.txtUkupnaCena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUkupnaCena.Enabled = false;
            this.txtUkupnaCena.Location = new System.Drawing.Point(253, 264);
            this.txtUkupnaCena.Name = "txtUkupnaCena";
            this.txtUkupnaCena.ReadOnly = true;
            this.txtUkupnaCena.Size = new System.Drawing.Size(162, 20);
            this.txtUkupnaCena.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Stornirana:";
            // 
            // txtStornirana
            // 
            this.txtStornirana.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStornirana.Enabled = false;
            this.txtStornirana.Location = new System.Drawing.Point(253, 331);
            this.txtStornirana.Name = "txtStornirana";
            this.txtStornirana.ReadOnly = true;
            this.txtStornirana.Size = new System.Drawing.Size(162, 20);
            this.txtStornirana.TabIndex = 19;
            // 
            // cbNacinPlacanja
            // 
            this.cbNacinPlacanja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbNacinPlacanja.Enabled = false;
            this.cbNacinPlacanja.FormattingEnabled = true;
            this.cbNacinPlacanja.Location = new System.Drawing.Point(253, 144);
            this.cbNacinPlacanja.Name = "cbNacinPlacanja";
            this.cbNacinPlacanja.Size = new System.Drawing.Size(162, 21);
            this.cbNacinPlacanja.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(285, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 41);
            this.button1.TabIndex = 21;
            this.button1.Text = "Storniraj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(56, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 41);
            this.button2.TabIndex = 22;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 398);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // FrmPrikaziFakturu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(548, 483);
            this.Controls.Add(this.cbNacinPlacanja);
            this.Controls.Add(this.txtStornirana);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUkupnaCena);
            this.Controls.Add(this.cbKorisnik);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.lblUkupnaCena);
            this.Controls.Add(this.lblNacinPlacanja);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPrikaziFakturu";
            this.Text = "Fakturu";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKorisnik;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.Label lblUkupnaCena;
        private System.Windows.Forms.Label lblNacinPlacanja;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.TextBox txtUkupnaCena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStornirana;
        private System.Windows.Forms.ComboBox cbNacinPlacanja;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;

        public ComboBox CbKorisnik { get => cbKorisnik; set => cbKorisnik = value; }
        public TextBox TxtDatum { get => txtDatum; set => txtDatum = value; }
        public Label LblKorisnik { get => lblKorisnik; set => lblKorisnik = value; }
        public Label LblUkupnaCena { get => lblUkupnaCena; set => lblUkupnaCena = value; }
        public Label LblNacinPlacanja { get => lblNacinPlacanja; set => lblNacinPlacanja = value; }
        public Label LblDatum { get => lblDatum; set => lblDatum = value; }
        public TextBox TxtUkupnaCena { get => txtUkupnaCena; set => txtUkupnaCena = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public TextBox TxtStornirana { get => txtStornirana; set => txtStornirana = value; }
        public ComboBox CbNacinPlacanja { get => cbNacinPlacanja; set => cbNacinPlacanja = value; }
        public Button Button1 { get => button1; set => button1 = value; }
        public Button Button2 { get => button2; set => button2 = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
    }
}