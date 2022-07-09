using System.Windows.Forms;

namespace KorisnickiInterfejs.Predavac
{
    partial class FrmPrikaziPredavaca
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
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblPol = new System.Windows.Forms.Label();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKurs = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnDodajKurs = new System.Windows.Forms.Button();
            this.btnIzbaci = new System.Windows.Forms.Button();
            this.dgvKursevi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursevi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(57, 69);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(43, 20);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.Location = new System.Drawing.Point(42, 124);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(75, 20);
            this.lblPrezime.TabIndex = 1;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblPol
            // 
            this.lblPol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPol.AutoSize = true;
            this.lblPol.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPol.Location = new System.Drawing.Point(57, 175);
            this.lblPol.Name = "lblPol";
            this.lblPol.Size = new System.Drawing.Size(40, 20);
            this.lblPol.TabIndex = 2;
            this.lblPol.Text = "Pol:";
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumRodjenja.Location = new System.Drawing.Point(18, 220);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(133, 20);
            this.lblDatumRodjenja.TabIndex = 3;
            this.lblDatumRodjenja.Text = "Datum rodjenja:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kurs:";
            // 
            // cbKurs
            // 
            this.cbKurs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbKurs.FormattingEnabled = true;
            this.cbKurs.Location = new System.Drawing.Point(177, 268);
            this.cbKurs.Name = "cbKurs";
            this.cbKurs.Size = new System.Drawing.Size(163, 21);
            this.cbKurs.TabIndex = 25;
            // 
            // cbGender
            // 
            this.cbGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbGender.Enabled = false;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(177, 174);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(163, 21);
            this.cbGender.TabIndex = 24;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.Location = new System.Drawing.Point(177, 68);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(163, 21);
            this.txtFirstName.TabIndex = 21;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.Location = new System.Drawing.Point(177, 123);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(163, 21);
            this.txtLastName.TabIndex = 22;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDateOfBirth.Enabled = false;
            this.txtDateOfBirth.Location = new System.Drawing.Point(177, 220);
            this.txtDateOfBirth.Multiline = true;
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(163, 21);
            this.txtDateOfBirth.TabIndex = 23;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnIzmeni.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(493, 102);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(163, 32);
            this.btnIzmeni.TabIndex = 26;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnDodajKurs
            // 
            this.btnDodajKurs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajKurs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDodajKurs.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKurs.Location = new System.Drawing.Point(177, 317);
            this.btnDodajKurs.Name = "btnDodajKurs";
            this.btnDodajKurs.Size = new System.Drawing.Size(163, 29);
            this.btnDodajKurs.TabIndex = 27;
            this.btnDodajKurs.Text = "Dodaj kurs";
            this.btnDodajKurs.UseVisualStyleBackColor = false;
            this.btnDodajKurs.Click += new System.EventHandler(this.btnDodajKurs_Click);
            // 
            // btnIzbaci
            // 
            this.btnIzbaci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzbaci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnIzbaci.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbaci.Location = new System.Drawing.Point(177, 384);
            this.btnIzbaci.Name = "btnIzbaci";
            this.btnIzbaci.Size = new System.Drawing.Size(163, 29);
            this.btnIzbaci.TabIndex = 28;
            this.btnIzbaci.Text = "Izbaci kurs";
            this.btnIzbaci.UseVisualStyleBackColor = false;
            this.btnIzbaci.Click += new System.EventHandler(this.btnIzbaci_Click);
            // 
            // dgvKursevi
            // 
            this.dgvKursevi.AllowUserToAddRows = false;
            this.dgvKursevi.AllowUserToDeleteRows = false;
            this.dgvKursevi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvKursevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKursevi.Location = new System.Drawing.Point(368, 220);
            this.dgvKursevi.Name = "dgvKursevi";
            this.dgvKursevi.ReadOnly = true;
            this.dgvKursevi.Size = new System.Drawing.Size(437, 210);
            this.dgvKursevi.TabIndex = 29;
            // 
            // FrmPrikaziPredavaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(817, 484);
            this.Controls.Add(this.dgvKursevi);
            this.Controls.Add(this.btnIzbaci);
            this.Controls.Add(this.btnDodajKurs);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.cbKurs);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtDateOfBirth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDatumRodjenja);
            this.Controls.Add(this.lblPol);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Name = "FrmPrikaziPredavaca";
            this.Text = "Predavac";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblPol;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKurs;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnDodajKurs;
        private System.Windows.Forms.Button btnIzbaci;
        private System.Windows.Forms.DataGridView dgvKursevi;

        public Label LblIme { get => lblIme; set => lblIme = value; }
        public Label LblPrezime { get => lblPrezime; set => lblPrezime = value; }
        public Label LblPol { get => lblPol; set => lblPol = value; }
        public Label LblDatumRodjenja { get => lblDatumRodjenja; set => lblDatumRodjenja = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public ComboBox CbKurs { get => cbKurs; set => cbKurs = value; }
        public ComboBox CbGender { get => cbGender; set => cbGender = value; }
        public TextBox TxtFirstName { get => txtFirstName; set => txtFirstName = value; }
        public TextBox TxtLastName { get => txtLastName; set => txtLastName = value; }
        public TextBox TxtDateOfBirth { get => txtDateOfBirth; set => txtDateOfBirth = value; }
        public Button BtnIzmeni { get => btnIzmeni; set => btnIzmeni = value; }
        public Button BtnDodajKurs { get => btnDodajKurs; set => btnDodajKurs = value; }
        public Button BtnIzbaci { get => btnIzbaci; set => btnIzbaci = value; }
        public DataGridView DgvKursevi { get => dgvKursevi; set => dgvKursevi = value; }
    }
}