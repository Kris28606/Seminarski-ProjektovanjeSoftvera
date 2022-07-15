using System.Windows.Forms;

namespace KorisnickiInterfejs.Korisnik
{
    partial class FrmPrikaziKorisnika
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
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtAdrress = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblAdrress = new System.Windows.Forms.Label();
            this.txtFirsName = new System.Windows.Forms.TextBox();
            this.txtMesto = new System.Windows.Forms.TextBox();
            this.btnDodajKorisnika = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlace
            // 
            this.lblPlace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.Location = new System.Drawing.Point(84, 273);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(61, 20);
            this.lblPlace.TabIndex = 18;
            this.lblPlace.Text = "Mesto:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(93, 62);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(43, 20);
            this.lblFirstName.TabIndex = 10;
            this.lblFirstName.Text = "Ime:";
            // 
            // txtAdrress
            // 
            this.txtAdrress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdrress.Enabled = false;
            this.txtAdrress.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdrress.Location = new System.Drawing.Point(184, 221);
            this.txtAdrress.Multiline = true;
            this.txtAdrress.Name = "txtAdrress";
            this.txtAdrress.Size = new System.Drawing.Size(163, 21);
            this.txtAdrress.TabIndex = 17;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(78, 112);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(75, 20);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Prezime:";
            // 
            // txtContact
            // 
            this.txtContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContact.Enabled = false;
            this.txtContact.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(184, 166);
            this.txtContact.Multiline = true;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(163, 21);
            this.txtContact.TabIndex = 16;
            // 
            // lblContact
            // 
            this.lblContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(77, 166);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(76, 20);
            this.lblContact.TabIndex = 12;
            this.lblContact.Text = "Kontakt:";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.Enabled = false;
            this.txtLastName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(184, 112);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(163, 21);
            this.txtLastName.TabIndex = 15;
            // 
            // lblAdrress
            // 
            this.lblAdrress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdrress.AutoSize = true;
            this.lblAdrress.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdrress.Location = new System.Drawing.Point(78, 221);
            this.lblAdrress.Name = "lblAdrress";
            this.lblAdrress.Size = new System.Drawing.Size(67, 20);
            this.lblAdrress.TabIndex = 13;
            this.lblAdrress.Text = "Adresa:";
            // 
            // txtFirsName
            // 
            this.txtFirsName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirsName.Enabled = false;
            this.txtFirsName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirsName.Location = new System.Drawing.Point(184, 62);
            this.txtFirsName.Multiline = true;
            this.txtFirsName.Name = "txtFirsName";
            this.txtFirsName.Size = new System.Drawing.Size(163, 20);
            this.txtFirsName.TabIndex = 14;
            // 
            // txtMesto
            // 
            this.txtMesto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMesto.Enabled = false;
            this.txtMesto.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesto.Location = new System.Drawing.Point(184, 273);
            this.txtMesto.Multiline = true;
            this.txtMesto.Name = "txtMesto";
            this.txtMesto.Size = new System.Drawing.Size(163, 21);
            this.txtMesto.TabIndex = 19;
            // 
            // btnDodajKorisnika
            // 
            this.btnDodajKorisnika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajKorisnika.BackColor = System.Drawing.Color.HotPink;
            this.btnDodajKorisnika.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKorisnika.Location = new System.Drawing.Point(232, 334);
            this.btnDodajKorisnika.Name = "btnDodajKorisnika";
            this.btnDodajKorisnika.Size = new System.Drawing.Size(197, 35);
            this.btnDodajKorisnika.TabIndex = 20;
            this.btnDodajKorisnika.Text = "Obrisi korisnika";
            this.btnDodajKorisnika.UseVisualStyleBackColor = false;
            this.btnDodajKorisnika.Click += new System.EventHandler(this.btnDodajKorisnika_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(49, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPrikaziKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(462, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDodajKorisnika);
            this.Controls.Add(this.txtMesto);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtAdrress);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblAdrress);
            this.Controls.Add(this.txtFirsName);
            this.Name = "FrmPrikaziKorisnika";
            this.Text = "Korisnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtAdrress;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblAdrress;
        private System.Windows.Forms.TextBox txtFirsName;
        private System.Windows.Forms.TextBox txtMesto;
        private System.Windows.Forms.Button btnDodajKorisnika;
        private System.Windows.Forms.Button button1;

        public Label LblPlace { get => lblPlace; set => lblPlace = value; }
        public Label LblFirstName { get => lblFirstName; set => lblFirstName = value; }
        public TextBox TxtAdrress { get => txtAdrress; set => txtAdrress = value; }
        public Label LblLastName { get => lblLastName; set => lblLastName = value; }
        public TextBox TxtContact { get => txtContact; set => txtContact = value; }
        public Label LblContact { get => lblContact; set => lblContact = value; }
        public TextBox TxtLastName { get => txtLastName; set => txtLastName = value; }
        public Label LblAdrress { get => lblAdrress; set => lblAdrress = value; }
        public TextBox TxtFirsName { get => txtFirsName; set => txtFirsName = value; }
        public TextBox TxtMesto { get => txtMesto; set => txtMesto = value; }
        public Button BtnDodajKorisnika { get => btnDodajKorisnika; set => btnDodajKorisnika = value; }
        public Button Button1 { get => button1; set => button1 = value; }
    }
}