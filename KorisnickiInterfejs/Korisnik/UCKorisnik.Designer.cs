using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    partial class UCKorisnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCKorisnik));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIzbaci = new System.Windows.Forms.Button();
            this.btnDodajKurs = new System.Windows.Forms.Button();
            this.dgvKursevi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKurs = new System.Windows.Forms.ComboBox();
            this.cbMesto = new System.Windows.Forms.ComboBox();
            this.lblPlace = new System.Windows.Forms.Label();
            this.btnDodajKorisnika = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtAdrress = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblAdrress = new System.Windows.Forms.Label();
            this.txtFirsName = new System.Windows.Forms.TextBox();
            this.lblKursGreska = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursevi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.lblKursGreska);
            this.groupBox1.Controls.Add(this.btnIzbaci);
            this.groupBox1.Controls.Add(this.btnDodajKurs);
            this.groupBox1.Controls.Add(this.dgvKursevi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbKurs);
            this.groupBox1.Controls.Add(this.cbMesto);
            this.groupBox1.Controls.Add(this.lblPlace);
            this.groupBox1.Controls.Add(this.btnDodajKorisnika);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Controls.Add(this.txtAdrress);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.txtContact);
            this.groupBox1.Controls.Add(this.lblContact);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.lblAdrress);
            this.groupBox1.Controls.Add(this.txtFirsName);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(838, 401);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj novog korisnika";
            // 
            // btnIzbaci
            // 
            this.btnIzbaci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzbaci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnIzbaci.Location = new System.Drawing.Point(681, 67);
            this.btnIzbaci.Name = "btnIzbaci";
            this.btnIzbaci.Size = new System.Drawing.Size(94, 28);
            this.btnIzbaci.TabIndex = 15;
            this.btnIzbaci.Text = "Izbaci kurs";
            this.btnIzbaci.UseVisualStyleBackColor = false;
            this.btnIzbaci.Click += new System.EventHandler(this.btnIzbaci_Click);
            // 
            // btnDodajKurs
            // 
            this.btnDodajKurs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDodajKurs.Location = new System.Drawing.Point(681, 24);
            this.btnDodajKurs.Name = "btnDodajKurs";
            this.btnDodajKurs.Size = new System.Drawing.Size(94, 28);
            this.btnDodajKurs.TabIndex = 14;
            this.btnDodajKurs.Text = "Dodaj kurs";
            this.btnDodajKurs.UseVisualStyleBackColor = false;
            this.btnDodajKurs.Click += new System.EventHandler(this.btnDodajKurs_Click);
            // 
            // dgvKursevi
            // 
            this.dgvKursevi.AllowUserToAddRows = false;
            this.dgvKursevi.AllowUserToDeleteRows = false;
            this.dgvKursevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKursevi.Location = new System.Drawing.Point(360, 101);
            this.dgvKursevi.Name = "dgvKursevi";
            this.dgvKursevi.ReadOnly = true;
            this.dgvKursevi.Size = new System.Drawing.Size(457, 211);
            this.dgvKursevi.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kurs:";
            // 
            // cbKurs
            // 
            this.cbKurs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbKurs.FormattingEnabled = true;
            this.cbKurs.Location = new System.Drawing.Point(492, 54);
            this.cbKurs.Name = "cbKurs";
            this.cbKurs.Size = new System.Drawing.Size(163, 24);
            this.cbKurs.TabIndex = 11;
            // 
            // cbMesto
            // 
            this.cbMesto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMesto.FormattingEnabled = true;
            this.cbMesto.Location = new System.Drawing.Point(146, 244);
            this.cbMesto.Name = "cbMesto";
            this.cbMesto.Size = new System.Drawing.Size(163, 24);
            this.cbMesto.TabIndex = 10;
            // 
            // lblPlace
            // 
            this.lblPlace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.Location = new System.Drawing.Point(46, 244);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(61, 20);
            this.lblPlace.TabIndex = 9;
            this.lblPlace.Text = "Mesto:";
            // 
            // btnDodajKorisnika
            // 
            this.btnDodajKorisnika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajKorisnika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDodajKorisnika.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKorisnika.Location = new System.Drawing.Point(130, 335);
            this.btnDodajKorisnika.Name = "btnDodajKorisnika";
            this.btnDodajKorisnika.Size = new System.Drawing.Size(197, 35);
            this.btnDodajKorisnika.TabIndex = 8;
            this.btnDodajKorisnika.Text = "Sacuvaj korisnika";
            this.btnDodajKorisnika.UseVisualStyleBackColor = false;
            this.btnDodajKorisnika.Click += new System.EventHandler(this.btnDodajKorisnika_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(57, 54);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(43, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Ime:";
            // 
            // txtAdrress
            // 
            this.txtAdrress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdrress.Location = new System.Drawing.Point(146, 198);
            this.txtAdrress.Multiline = true;
            this.txtAdrress.Name = "txtAdrress";
            this.txtAdrress.Size = new System.Drawing.Size(163, 21);
            this.txtAdrress.TabIndex = 7;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(40, 101);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(75, 20);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Prezime:";
            // 
            // txtContact
            // 
            this.txtContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContact.Location = new System.Drawing.Point(146, 150);
            this.txtContact.Multiline = true;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(163, 21);
            this.txtContact.TabIndex = 6;
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            // 
            // lblContact
            // 
            this.lblContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(39, 150);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(76, 20);
            this.lblContact.TabIndex = 2;
            this.lblContact.Text = "Kontakt:";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.Location = new System.Drawing.Point(146, 101);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(163, 21);
            this.txtLastName.TabIndex = 5;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // lblAdrress
            // 
            this.lblAdrress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdrress.AutoSize = true;
            this.lblAdrress.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdrress.Location = new System.Drawing.Point(40, 198);
            this.lblAdrress.Name = "lblAdrress";
            this.lblAdrress.Size = new System.Drawing.Size(67, 20);
            this.lblAdrress.TabIndex = 3;
            this.lblAdrress.Text = "Adresa:";
            // 
            // txtFirsName
            // 
            this.txtFirsName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirsName.Location = new System.Drawing.Point(146, 54);
            this.txtFirsName.Multiline = true;
            this.txtFirsName.Name = "txtFirsName";
            this.txtFirsName.Size = new System.Drawing.Size(163, 20);
            this.txtFirsName.TabIndex = 4;
            this.txtFirsName.TextChanged += new System.EventHandler(this.txtFirsName_TextChanged);
            // 
            // lblKursGreska
            // 
            this.lblKursGreska.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKursGreska.AutoSize = true;
            this.lblKursGreska.Location = new System.Drawing.Point(415, 82);
            this.lblKursGreska.Name = "lblKursGreska";
            this.lblKursGreska.Size = new System.Drawing.Size(0, 16);
            this.lblKursGreska.TabIndex = 16;
            // 
            // UCKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.groupBox1);
            this.Name = "UCKorisnik";
            this.Size = new System.Drawing.Size(882, 506);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursevi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMesto;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Button btnDodajKorisnika;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtAdrress;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblAdrress;
        private System.Windows.Forms.TextBox txtFirsName;
        private System.Windows.Forms.Button btnDodajKurs;
        private System.Windows.Forms.DataGridView dgvKursevi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKurs;
        private Button btnIzbaci;
        private Label lblKursGreska;

        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public ComboBox CbMesto { get => cbMesto; set => cbMesto = value; }
        public Label LblPlace { get => lblPlace; set => lblPlace = value; }
        public Button BtnDodajKorisnika { get => btnDodajKorisnika; set => btnDodajKorisnika = value; }
        public Label LblFirstName { get => lblFirstName; set => lblFirstName = value; }
        public TextBox TxtAdrress { get => txtAdrress; set => txtAdrress = value; }
        public Label LblLastName { get => lblLastName; set => lblLastName = value; }
        public TextBox TxtContact { get => txtContact; set => txtContact = value; }
        public Label LblContact { get => lblContact; set => lblContact = value; }
        public TextBox TxtLastName { get => txtLastName; set => txtLastName = value; }
        public Label LblAdrress { get => lblAdrress; set => lblAdrress = value; }
        public TextBox TxtFirsName { get => txtFirsName; set => txtFirsName = value; }
        public Button BtnDodajKurs { get => btnDodajKurs; set => btnDodajKurs = value; }
        public DataGridView DgvKursevi { get => dgvKursevi; set => dgvKursevi = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public ComboBox CbKurs { get => cbKurs; set => cbKurs = value; }
        public Button BtnIzbaci { get => btnIzbaci; set => btnIzbaci = value; }
        public Label LblKursGreska { get => lblKursGreska; set => lblKursGreska = value; }
    }
}
