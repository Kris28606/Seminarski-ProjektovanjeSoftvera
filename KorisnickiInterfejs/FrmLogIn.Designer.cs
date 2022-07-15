using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    partial class FrmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogIn));
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.pbHide = new System.Windows.Forms.PictureBox();
            this.pbShow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(132, 100);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 20);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(118, 153);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(87, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(224, 90);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(231, 30);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(224, 143);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(231, 30);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLogIn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(224, 205);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(231, 37);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Prijavi se";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // pbHide
            // 
            this.pbHide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbHide.BackColor = System.Drawing.Color.Transparent;
            this.pbHide.Image = ((System.Drawing.Image)(resources.GetObject("pbHide.Image")));
            this.pbHide.Location = new System.Drawing.Point(472, 143);
            this.pbHide.Name = "pbHide";
            this.pbHide.Size = new System.Drawing.Size(30, 30);
            this.pbHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHide.TabIndex = 5;
            this.pbHide.TabStop = false;
            this.pbHide.Visible = false;
            this.pbHide.Click += new System.EventHandler(this.pbHide_Click);
            // 
            // pbShow
            // 
            this.pbShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbShow.BackColor = System.Drawing.Color.Transparent;
            this.pbShow.Image = ((System.Drawing.Image)(resources.GetObject("pbShow.Image")));
            this.pbShow.Location = new System.Drawing.Point(472, 143);
            this.pbShow.Name = "pbShow";
            this.pbShow.Size = new System.Drawing.Size(30, 30);
            this.pbShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShow.TabIndex = 6;
            this.pbShow.TabStop = false;
            this.pbShow.Click += new System.EventHandler(this.pbShow_Click);
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(623, 341);
            this.Controls.Add(this.pbShow);
            this.Controls.Add(this.pbHide);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Name = "FrmLogIn";
            this.Text = "Prijava";
            ((System.ComponentModel.ISupportInitialize)(this.pbHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.PictureBox pbHide;
        private System.Windows.Forms.PictureBox pbShow;

        public Label LblEmail { get => lblEmail; set => lblEmail = value; }
        public Label LblPassword { get => lblPassword; set => lblPassword = value; }
        public TextBox TxtEmail { get => txtEmail; set => txtEmail = value; }
        public TextBox TxtPassword { get => txtPassword; set => txtPassword = value; }
        public Button BtnLogIn { get => btnLogIn; set => btnLogIn = value; }
        public PictureBox PbHide { get => pbHide; set => pbHide = value; }
        public PictureBox PbShow { get => pbShow; set => pbShow = value; }
    }
}

