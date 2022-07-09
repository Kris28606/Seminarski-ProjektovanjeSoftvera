using System.ComponentModel;
using System.Windows.Forms;

namespace KorisnickiInterfejs.Faktura
{
    partial class UCFaktura
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
            this.lblNacinPlacanja = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblUkupnaCena = new System.Windows.Forms.Label();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.gbFaktura = new System.Windows.Forms.GroupBox();
            this.lblNijeSelektovanaStavka = new System.Windows.Forms.Label();
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            this.lblDatumGreska = new System.Windows.Forms.Label();
            this.lblGreska = new System.Windows.Forms.Label();
            this.btnSacuvajFakturu = new System.Windows.Forms.Button();
            this.dgvStavkeFakture = new System.Windows.Forms.DataGridView();
            this.cbNacinPlacanja = new System.Windows.Forms.ComboBox();
            this.cbKorisnik = new System.Windows.Forms.ComboBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtUkupnaCena = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.cbKurs = new System.Windows.Forms.ComboBox();
            this.txtVrednostStavke = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbFaktura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeFakture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNacinPlacanja
            // 
            this.lblNacinPlacanja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNacinPlacanja.AutoSize = true;
            this.lblNacinPlacanja.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacinPlacanja.Location = new System.Drawing.Point(27, 113);
            this.lblNacinPlacanja.Name = "lblNacinPlacanja";
            this.lblNacinPlacanja.Size = new System.Drawing.Size(105, 16);
            this.lblNacinPlacanja.TabIndex = 0;
            this.lblNacinPlacanja.Text = "Nacin placanja:";
            // 
            // lblDatum
            // 
            this.lblDatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(54, 159);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(54, 16);
            this.lblDatum.TabIndex = 1;
            this.lblDatum.Text = "Datum:";
            // 
            // lblUkupnaCena
            // 
            this.lblUkupnaCena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUkupnaCena.AutoSize = true;
            this.lblUkupnaCena.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupnaCena.Location = new System.Drawing.Point(37, 207);
            this.lblUkupnaCena.Name = "lblUkupnaCena";
            this.lblUkupnaCena.Size = new System.Drawing.Size(95, 16);
            this.lblUkupnaCena.TabIndex = 2;
            this.lblUkupnaCena.Text = "Ukupna cena:";
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnik.Location = new System.Drawing.Point(54, 58);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(66, 16);
            this.lblKorisnik.TabIndex = 3;
            this.lblKorisnik.Text = "Korisnik:";
            // 
            // gbFaktura
            // 
            this.gbFaktura.Controls.Add(this.lblNijeSelektovanaStavka);
            this.gbFaktura.Controls.Add(this.btnObrisiStavku);
            this.gbFaktura.Controls.Add(this.lblDatumGreska);
            this.gbFaktura.Controls.Add(this.lblGreska);
            this.gbFaktura.Controls.Add(this.btnSacuvajFakturu);
            this.gbFaktura.Controls.Add(this.dgvStavkeFakture);
            this.gbFaktura.Controls.Add(this.cbNacinPlacanja);
            this.gbFaktura.Controls.Add(this.cbKorisnik);
            this.gbFaktura.Controls.Add(this.txtDatum);
            this.gbFaktura.Controls.Add(this.txtUkupnaCena);
            this.gbFaktura.Controls.Add(this.groupBox1);
            this.gbFaktura.Controls.Add(this.lblKorisnik);
            this.gbFaktura.Controls.Add(this.lblUkupnaCena);
            this.gbFaktura.Controls.Add(this.lblNacinPlacanja);
            this.gbFaktura.Controls.Add(this.lblDatum);
            this.gbFaktura.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFaktura.Location = new System.Drawing.Point(15, 26);
            this.gbFaktura.Name = "gbFaktura";
            this.gbFaktura.Size = new System.Drawing.Size(850, 481);
            this.gbFaktura.TabIndex = 4;
            this.gbFaktura.TabStop = false;
            this.gbFaktura.Text = "Nova faktura";
            // 
            // lblNijeSelektovanaStavka
            // 
            this.lblNijeSelektovanaStavka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNijeSelektovanaStavka.AutoSize = true;
            this.lblNijeSelektovanaStavka.ForeColor = System.Drawing.Color.Red;
            this.lblNijeSelektovanaStavka.Location = new System.Drawing.Point(460, 195);
            this.lblNijeSelektovanaStavka.Name = "lblNijeSelektovanaStavka";
            this.lblNijeSelektovanaStavka.Size = new System.Drawing.Size(0, 14);
            this.lblNijeSelektovanaStavka.TabIndex = 16;
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisiStavku.BackColor = System.Drawing.Color.LightCoral;
            this.btnObrisiStavku.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiStavku.Location = new System.Drawing.Point(682, 184);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(162, 34);
            this.btnObrisiStavku.TabIndex = 15;
            this.btnObrisiStavku.Text = "Obrisi stavku";
            this.btnObrisiStavku.UseVisualStyleBackColor = false;
            this.btnObrisiStavku.Click += new System.EventHandler(this.btnObrisiStavku_Click);
            // 
            // lblDatumGreska
            // 
            this.lblDatumGreska.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatumGreska.AutoSize = true;
            this.lblDatumGreska.ForeColor = System.Drawing.Color.Red;
            this.lblDatumGreska.Location = new System.Drawing.Point(328, 161);
            this.lblDatumGreska.Name = "lblDatumGreska";
            this.lblDatumGreska.Size = new System.Drawing.Size(0, 14);
            this.lblDatumGreska.TabIndex = 14;
            // 
            // lblGreska
            // 
            this.lblGreska.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGreska.AutoSize = true;
            this.lblGreska.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreska.ForeColor = System.Drawing.Color.Red;
            this.lblGreska.Location = new System.Drawing.Point(27, 239);
            this.lblGreska.Name = "lblGreska";
            this.lblGreska.Size = new System.Drawing.Size(0, 14);
            this.lblGreska.TabIndex = 13;
            // 
            // btnSacuvajFakturu
            // 
            this.btnSacuvajFakturu.BackColor = System.Drawing.Color.Thistle;
            this.btnSacuvajFakturu.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajFakturu.Location = new System.Drawing.Point(432, 58);
            this.btnSacuvajFakturu.Name = "btnSacuvajFakturu";
            this.btnSacuvajFakturu.Size = new System.Drawing.Size(162, 30);
            this.btnSacuvajFakturu.TabIndex = 12;
            this.btnSacuvajFakturu.Text = "Sacuvaj";
            this.btnSacuvajFakturu.UseVisualStyleBackColor = false;
            this.btnSacuvajFakturu.Click += new System.EventHandler(this.btnSacuvajFakturu_Click);
            // 
            // dgvStavkeFakture
            // 
            this.dgvStavkeFakture.AllowUserToAddRows = false;
            this.dgvStavkeFakture.AllowUserToDeleteRows = false;
            this.dgvStavkeFakture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeFakture.Location = new System.Drawing.Point(398, 224);
            this.dgvStavkeFakture.Name = "dgvStavkeFakture";
            this.dgvStavkeFakture.ReadOnly = true;
            this.dgvStavkeFakture.Size = new System.Drawing.Size(446, 257);
            this.dgvStavkeFakture.TabIndex = 11;
            // 
            // cbNacinPlacanja
            // 
            this.cbNacinPlacanja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbNacinPlacanja.FormattingEnabled = true;
            this.cbNacinPlacanja.Location = new System.Drawing.Point(160, 112);
            this.cbNacinPlacanja.Name = "cbNacinPlacanja";
            this.cbNacinPlacanja.Size = new System.Drawing.Size(162, 22);
            this.cbNacinPlacanja.TabIndex = 10;
            // 
            // cbKorisnik
            // 
            this.cbKorisnik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbKorisnik.FormattingEnabled = true;
            this.cbKorisnik.Location = new System.Drawing.Point(160, 57);
            this.cbKorisnik.Name = "cbKorisnik";
            this.cbKorisnik.Size = new System.Drawing.Size(162, 22);
            this.cbKorisnik.TabIndex = 9;
            this.cbKorisnik.SelectedIndexChanged += new System.EventHandler(this.cbKorisnik_SelectedIndexChanged);
            // 
            // txtDatum
            // 
            this.txtDatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatum.Location = new System.Drawing.Point(160, 158);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(162, 22);
            this.txtDatum.TabIndex = 8;
            // 
            // txtUkupnaCena
            // 
            this.txtUkupnaCena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUkupnaCena.Location = new System.Drawing.Point(160, 206);
            this.txtUkupnaCena.Name = "txtUkupnaCena";
            this.txtUkupnaCena.ReadOnly = true;
            this.txtUkupnaCena.Size = new System.Drawing.Size(162, 22);
            this.txtUkupnaCena.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodajStavku);
            this.groupBox1.Controls.Add(this.cbKurs);
            this.groupBox1.Controls.Add(this.txtVrednostStavke);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 210);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stavka fakture";
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDodajStavku.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajStavku.Location = new System.Drawing.Point(154, 158);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(162, 32);
            this.btnDodajStavku.TabIndex = 11;
            this.btnDodajStavku.Text = "Dodaj";
            this.btnDodajStavku.UseVisualStyleBackColor = false;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // cbKurs
            // 
            this.cbKurs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbKurs.FormattingEnabled = true;
            this.cbKurs.Location = new System.Drawing.Point(154, 58);
            this.cbKurs.Name = "cbKurs";
            this.cbKurs.Size = new System.Drawing.Size(162, 22);
            this.cbKurs.TabIndex = 11;
            this.cbKurs.SelectedIndexChanged += new System.EventHandler(this.cbKurs_SelectedIndexChanged);
            // 
            // txtVrednostStavke
            // 
            this.txtVrednostStavke.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVrednostStavke.Location = new System.Drawing.Point(154, 112);
            this.txtVrednostStavke.Name = "txtVrednostStavke";
            this.txtVrednostStavke.ReadOnly = true;
            this.txtVrednostStavke.Size = new System.Drawing.Size(162, 22);
            this.txtVrednostStavke.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vrednost stavke:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kurs:";
            // 
            // UCFaktura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.gbFaktura);
            this.Name = "UCFaktura";
            this.Size = new System.Drawing.Size(882, 523);
            this.gbFaktura.ResumeLayout(false);
            this.gbFaktura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeFakture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNacinPlacanja;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblUkupnaCena;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.GroupBox gbFaktura;
        private System.Windows.Forms.Button btnSacuvajFakturu;
        private System.Windows.Forms.DataGridView dgvStavkeFakture;
        private System.Windows.Forms.ComboBox cbNacinPlacanja;
        private System.Windows.Forms.ComboBox cbKorisnik;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtUkupnaCena;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.ComboBox cbKurs;
        private System.Windows.Forms.TextBox txtVrednostStavke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblDatumGreska;
        private System.Windows.Forms.Label lblGreska;
        private System.Windows.Forms.Button btnObrisiStavku;
        private System.Windows.Forms.Label lblNijeSelektovanaStavka;

        public Label LblNacinPlacanja { get => lblNacinPlacanja; set => lblNacinPlacanja = value; }
        public Label LblDatum { get => lblDatum; set => lblDatum = value; }
        public Label LblUkupnaCena { get => lblUkupnaCena; set => lblUkupnaCena = value; }
        public Label LblKorisnik { get => lblKorisnik; set => lblKorisnik = value; }
        public GroupBox GbFaktura { get => gbFaktura; set => gbFaktura = value; }
        public Button BtnSacuvajFakturu { get => btnSacuvajFakturu; set => btnSacuvajFakturu = value; }
        public DataGridView DgvStavkeFakture { get => dgvStavkeFakture; set => dgvStavkeFakture = value; }
        public ComboBox CbNacinPlacanja { get => cbNacinPlacanja; set => cbNacinPlacanja = value; }
        public ComboBox CbKorisnik { get => cbKorisnik; set => cbKorisnik = value; }
        public TextBox TxtDatum { get => txtDatum; set => txtDatum = value; }
        public TextBox TxtUkupnaCena { get => txtUkupnaCena; set => txtUkupnaCena = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public Button BtnDodajStavku { get => btnDodajStavku; set => btnDodajStavku = value; }
        public ComboBox CbKurs { get => cbKurs; set => cbKurs = value; }
        public TextBox TxtVrednostStavke { get => txtVrednostStavke; set => txtVrednostStavke = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public BackgroundWorker BackgroundWorker1 { get => backgroundWorker1; set => backgroundWorker1 = value; }
        public Label LblDatumGreska { get => lblDatumGreska; set => lblDatumGreska = value; }
        public Label LblGreska { get => lblGreska; set => lblGreska = value; }
        public Button BtnObrisiStavku { get => btnObrisiStavku; set => btnObrisiStavku = value; }
        public Label LblNijeSelektovanaStavka { get => lblNijeSelektovanaStavka; set => lblNijeSelektovanaStavka = value; }
    }
}
