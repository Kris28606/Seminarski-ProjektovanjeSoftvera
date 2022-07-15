namespace KorisnickiInterfejs
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviKursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kurseviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predavacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovogPredavacaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predavaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovogKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fakturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaFakturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stornirajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPrezimePrijavljenog = new System.Windows.Forms.Label();
            this.lblImePrijavljenog = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.kursToolStripMenuItem,
            this.predavacToolStripMenuItem,
            this.korisnikToolStripMenuItem,
            this.fakturaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // kursToolStripMenuItem
            // 
            this.kursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNoviKursToolStripMenuItem,
            this.kurseviToolStripMenuItem});
            this.kursToolStripMenuItem.Name = "kursToolStripMenuItem";
            this.kursToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.kursToolStripMenuItem.Text = "Kurs";
            // 
            // dodajNoviKursToolStripMenuItem
            // 
            this.dodajNoviKursToolStripMenuItem.Name = "dodajNoviKursToolStripMenuItem";
            this.dodajNoviKursToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.dodajNoviKursToolStripMenuItem.Text = "Dodaj novi kurs";
            this.dodajNoviKursToolStripMenuItem.Click += new System.EventHandler(this.dodajNoviKursToolStripMenuItem_Click);
            // 
            // kurseviToolStripMenuItem
            // 
            this.kurseviToolStripMenuItem.Name = "kurseviToolStripMenuItem";
            this.kurseviToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.kurseviToolStripMenuItem.Text = "Kursevi";
            this.kurseviToolStripMenuItem.Click += new System.EventHandler(this.kurseviToolStripMenuItem_Click);
            // 
            // predavacToolStripMenuItem
            // 
            this.predavacToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNovogPredavacaToolStripMenuItem,
            this.predavaciToolStripMenuItem});
            this.predavacToolStripMenuItem.Name = "predavacToolStripMenuItem";
            this.predavacToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.predavacToolStripMenuItem.Text = "Predavac";
            // 
            // dodajNovogPredavacaToolStripMenuItem
            // 
            this.dodajNovogPredavacaToolStripMenuItem.Name = "dodajNovogPredavacaToolStripMenuItem";
            this.dodajNovogPredavacaToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.dodajNovogPredavacaToolStripMenuItem.Text = "Dodaj novog predavaca";
            this.dodajNovogPredavacaToolStripMenuItem.Click += new System.EventHandler(this.dodajNovogPredavacaToolStripMenuItem_Click);
            // 
            // predavaciToolStripMenuItem
            // 
            this.predavaciToolStripMenuItem.Name = "predavaciToolStripMenuItem";
            this.predavaciToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.predavaciToolStripMenuItem.Text = "Predavaci";
            this.predavaciToolStripMenuItem.Click += new System.EventHandler(this.predavaciToolStripMenuItem_Click);
            // 
            // korisnikToolStripMenuItem
            // 
            this.korisnikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNovogKorisnikaToolStripMenuItem,
            this.korisniciToolStripMenuItem});
            this.korisnikToolStripMenuItem.Name = "korisnikToolStripMenuItem";
            this.korisnikToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.korisnikToolStripMenuItem.Text = "Korisnik";
            // 
            // dodajNovogKorisnikaToolStripMenuItem
            // 
            this.dodajNovogKorisnikaToolStripMenuItem.Name = "dodajNovogKorisnikaToolStripMenuItem";
            this.dodajNovogKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.dodajNovogKorisnikaToolStripMenuItem.Text = "Dodaj novog korisnika";
            this.dodajNovogKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajNovogKorisnikaToolStripMenuItem_Click);
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            this.korisniciToolStripMenuItem.Click += new System.EventHandler(this.korisniciToolStripMenuItem_Click);
            // 
            // fakturaToolStripMenuItem
            // 
            this.fakturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaFakturaToolStripMenuItem,
            this.stornirajToolStripMenuItem});
            this.fakturaToolStripMenuItem.Name = "fakturaToolStripMenuItem";
            this.fakturaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.fakturaToolStripMenuItem.Text = "Faktura";
            // 
            // novaFakturaToolStripMenuItem
            // 
            this.novaFakturaToolStripMenuItem.Name = "novaFakturaToolStripMenuItem";
            this.novaFakturaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.novaFakturaToolStripMenuItem.Text = "Nova faktura";
            this.novaFakturaToolStripMenuItem.Click += new System.EventHandler(this.novaFakturaToolStripMenuItem_Click);
            // 
            // stornirajToolStripMenuItem
            // 
            this.stornirajToolStripMenuItem.Name = "stornirajToolStripMenuItem";
            this.stornirajToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.stornirajToolStripMenuItem.Text = "Storniraj fakturu";
            this.stornirajToolStripMenuItem.Click += new System.EventHandler(this.stornirajToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblPrezimePrijavljenog);
            this.groupBox1.Controls.Add(this.lblImePrijavljenog);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prijavljeni korisnik";
            // 
            // lblPrezimePrijavljenog
            // 
            this.lblPrezimePrijavljenog.AutoSize = true;
            this.lblPrezimePrijavljenog.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezimePrijavljenog.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPrezimePrijavljenog.Location = new System.Drawing.Point(58, 91);
            this.lblPrezimePrijavljenog.Name = "lblPrezimePrijavljenog";
            this.lblPrezimePrijavljenog.Size = new System.Drawing.Size(0, 25);
            this.lblPrezimePrijavljenog.TabIndex = 1;
            // 
            // lblImePrijavljenog
            // 
            this.lblImePrijavljenog.AutoSize = true;
            this.lblImePrijavljenog.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImePrijavljenog.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblImePrijavljenog.Location = new System.Drawing.Point(58, 52);
            this.lblImePrijavljenog.Name = "lblImePrijavljenog";
            this.lblImePrijavljenog.Size = new System.Drawing.Size(0, 25);
            this.lblImePrijavljenog.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1084, 637);
            this.pnlMain.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Skola stranih jezika";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predavacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fakturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaFakturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stornirajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblImePrijavljenog;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblPrezimePrijavljenog;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviKursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kurseviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovogPredavacaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predavaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovogKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
    }
}