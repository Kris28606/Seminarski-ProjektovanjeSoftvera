using System.Windows.Forms;

namespace KorisnickiInterfejs.Kurs
{
    partial class FrmPrikaziKurs
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
            this.btnIzmeniKurs = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIzmeniKurs
            // 
            this.btnIzmeniKurs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeniKurs.BackColor = System.Drawing.Color.SkyBlue;
            this.btnIzmeniKurs.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniKurs.Location = new System.Drawing.Point(194, 281);
            this.btnIzmeniKurs.Name = "btnIzmeniKurs";
            this.btnIzmeniKurs.Size = new System.Drawing.Size(163, 37);
            this.btnIzmeniKurs.TabIndex = 8;
            this.btnIzmeniKurs.Text = "Izmeni";
            this.btnIzmeniKurs.UseVisualStyleBackColor = false;
            this.btnIzmeniKurs.Click += new System.EventHandler(this.btnIzmeniKurs_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(73, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Naziv:";
            // 
            // txtTime
            // 
            this.txtTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTime.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(194, 224);
            this.txtTime.Multiline = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(163, 21);
            this.txtTime.TabIndex = 7;
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(73, 128);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 20);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Cena:";
            // 
            // txtDate
            // 
            this.txtDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(194, 176);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(163, 21);
            this.txtDate.TabIndex = 6;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(37, 176);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(130, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Datum pocetka:";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(194, 128);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(163, 21);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(56, 224);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(76, 20);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Trajanje:";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(194, 78);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 21);
            this.txtName.TabIndex = 4;
            // 
            // FrmPrikaziKurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(462, 381);
            this.Controls.Add(this.btnIzmeniKurs);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblDate);
            this.Name = "FrmPrikaziKurs";
            this.Text = "Kurs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzmeniKurs;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtName;

        public Button BtnIzmeniKurs { get => btnIzmeniKurs; set => btnIzmeniKurs = value; }
        public Label LblName { get => lblName; set => lblName = value; }
        public TextBox TxtTime { get => txtTime; set => txtTime = value; }
        public Label LblPrice { get => lblPrice; set => lblPrice = value; }
        public TextBox TxtDate { get => txtDate; set => txtDate = value; }
        public Label LblDate { get => lblDate; set => lblDate = value; }
        public TextBox TxtPrice { get => txtPrice; set => txtPrice = value; }
        public Label LblTime { get => lblTime; set => lblTime = value; }
        public TextBox TxtName { get => txtName; set => txtName = value; }
    }
}