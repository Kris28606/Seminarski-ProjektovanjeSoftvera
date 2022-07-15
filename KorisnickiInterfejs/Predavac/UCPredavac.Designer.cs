using System.Windows.Forms;

namespace KorisnickiInterfejs.Predavac
{
    partial class UCPredavac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPredavac));
            this.btnSacuvajPredavaca = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIzbaci = new System.Windows.Forms.Button();
            this.lblNemaKurseva = new System.Windows.Forms.Label();
            this.btnDodajKurs = new System.Windows.Forms.Button();
            this.dgvKursevi = new System.Windows.Forms.DataGridView();
            this.lblDatumGreska = new System.Windows.Forms.Label();
            this.cbKurs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursevi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSacuvajPredavaca
            // 
            this.btnSacuvajPredavaca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvajPredavaca.BackColor = System.Drawing.Color.Plum;
            this.btnSacuvajPredavaca.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajPredavaca.Location = new System.Drawing.Point(174, 476);
            this.btnSacuvajPredavaca.Name = "btnSacuvajPredavaca";
            this.btnSacuvajPredavaca.Size = new System.Drawing.Size(205, 37);
            this.btnSacuvajPredavaca.TabIndex = 17;
            this.btnSacuvajPredavaca.Text = "Sacuvaj predavaca";
            this.btnSacuvajPredavaca.UseVisualStyleBackColor = false;
            this.btnSacuvajPredavaca.Click += new System.EventHandler(this.btnAddCours_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(97, 42);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(43, 20);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "Ime:";
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDateOfBirth.Location = new System.Drawing.Point(197, 194);
            this.txtDateOfBirth.Multiline = true;
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(163, 21);
            this.txtDateOfBirth.TabIndex = 16;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(79, 88);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(75, 20);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Prezime:";
            // 
            // lblGender
            // 
            this.lblGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(97, 140);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(40, 20);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Pol:";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.Location = new System.Drawing.Point(197, 88);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(163, 21);
            this.txtLastName.TabIndex = 14;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(58, 194);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(133, 20);
            this.lblDateOfBirth.TabIndex = 12;
            this.lblDateOfBirth.Text = "Datum rodjenja:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.Location = new System.Drawing.Point(197, 42);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(163, 21);
            this.txtFirstName.TabIndex = 13;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // cbGender
            // 
            this.cbGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(197, 140);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(163, 24);
            this.cbGender.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Pink;
            this.groupBox1.Controls.Add(this.btnIzbaci);
            this.groupBox1.Controls.Add(this.lblNemaKurseva);
            this.groupBox1.Controls.Add(this.btnDodajKurs);
            this.groupBox1.Controls.Add(this.dgvKursevi);
            this.groupBox1.Controls.Add(this.btnSacuvajPredavaca);
            this.groupBox1.Controls.Add(this.lblDatumGreska);
            this.groupBox1.Controls.Add(this.cbKurs);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbGender);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.lblDateOfBirth);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtDateOfBirth);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 532);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj novog predavaca";
            // 
            // btnIzbaci
            // 
            this.btnIzbaci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzbaci.BackColor = System.Drawing.Color.Plum;
            this.btnIzbaci.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbaci.Location = new System.Drawing.Point(375, 260);
            this.btnIzbaci.Name = "btnIzbaci";
            this.btnIzbaci.Size = new System.Drawing.Size(101, 24);
            this.btnIzbaci.TabIndex = 25;
            this.btnIzbaci.Text = "Izbaci";
            this.btnIzbaci.UseVisualStyleBackColor = false;
            this.btnIzbaci.Click += new System.EventHandler(this.btnIzbaci_Click);
            // 
            // lblNemaKurseva
            // 
            this.lblNemaKurseva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNemaKurseva.AutoSize = true;
            this.lblNemaKurseva.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNemaKurseva.ForeColor = System.Drawing.Color.Red;
            this.lblNemaKurseva.Location = new System.Drawing.Point(203, 273);
            this.lblNemaKurseva.Name = "lblNemaKurseva";
            this.lblNemaKurseva.Size = new System.Drawing.Size(0, 14);
            this.lblNemaKurseva.TabIndex = 24;
            // 
            // btnDodajKurs
            // 
            this.btnDodajKurs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajKurs.BackColor = System.Drawing.Color.Plum;
            this.btnDodajKurs.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKurs.Location = new System.Drawing.Point(375, 227);
            this.btnDodajKurs.Name = "btnDodajKurs";
            this.btnDodajKurs.Size = new System.Drawing.Size(101, 24);
            this.btnDodajKurs.TabIndex = 23;
            this.btnDodajKurs.Text = "Dodaj";
            this.btnDodajKurs.UseVisualStyleBackColor = false;
            this.btnDodajKurs.Click += new System.EventHandler(this.btnDodajKurs_Click);
            // 
            // dgvKursevi
            // 
            this.dgvKursevi.AllowUserToAddRows = false;
            this.dgvKursevi.AllowUserToDeleteRows = false;
            this.dgvKursevi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvKursevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKursevi.Location = new System.Drawing.Point(24, 290);
            this.dgvKursevi.Name = "dgvKursevi";
            this.dgvKursevi.ReadOnly = true;
            this.dgvKursevi.Size = new System.Drawing.Size(474, 180);
            this.dgvKursevi.TabIndex = 22;
            // 
            // lblDatumGreska
            // 
            this.lblDatumGreska.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatumGreska.AutoSize = true;
            this.lblDatumGreska.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumGreska.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDatumGreska.Location = new System.Drawing.Point(256, 311);
            this.lblDatumGreska.Name = "lblDatumGreska";
            this.lblDatumGreska.Size = new System.Drawing.Size(0, 16);
            this.lblDatumGreska.TabIndex = 21;
            // 
            // cbKurs
            // 
            this.cbKurs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbKurs.FormattingEnabled = true;
            this.cbKurs.Location = new System.Drawing.Point(197, 246);
            this.cbKurs.Name = "cbKurs";
            this.cbKurs.Size = new System.Drawing.Size(163, 24);
            this.cbKurs.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kurs:";
            // 
            // UCPredavac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "UCPredavac";
            this.Size = new System.Drawing.Size(1100, 700);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursevi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvajPredavaca;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbKurs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDatumGreska;
        private System.Windows.Forms.Button btnDodajKurs;
        private System.Windows.Forms.DataGridView dgvKursevi;
        private System.Windows.Forms.Label lblNemaKurseva;
        private Button btnIzbaci;

        public Button BtnSacuvajPredavaca { get => btnSacuvajPredavaca; set => btnSacuvajPredavaca = value; }
        public Label LblFirstName { get => lblFirstName; set => lblFirstName = value; }
        public TextBox TxtDateOfBirth { get => txtDateOfBirth; set => txtDateOfBirth = value; }
        public Label LblLastName { get => lblLastName; set => lblLastName = value; }
        public Label LblGender { get => lblGender; set => lblGender = value; }
        public TextBox TxtLastName { get => txtLastName; set => txtLastName = value; }
        public Label LblDateOfBirth { get => lblDateOfBirth; set => lblDateOfBirth = value; }
        public TextBox TxtFirstName { get => txtFirstName; set => txtFirstName = value; }
        public ComboBox CbGender { get => cbGender; set => cbGender = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public ComboBox CbKurs { get => cbKurs; set => cbKurs = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label LblDatumGreska { get => lblDatumGreska; set => lblDatumGreska = value; }
        public Button BtnDodajKurs { get => btnDodajKurs; set => btnDodajKurs = value; }
        public DataGridView DgvKursevi { get => dgvKursevi; set => dgvKursevi = value; }
        public Label LblNemaKurseva { get => lblNemaKurseva; set => lblNemaKurseva = value; }
        public Button BtnIzbaci { get => btnIzbaci; set => btnIzbaci = value; }
    }
}
