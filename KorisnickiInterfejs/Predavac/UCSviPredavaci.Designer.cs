using System.Windows.Forms;

namespace KorisnickiInterfejs.Predavac
{
    partial class UCSviPredavaci
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSviPredavaci));
            this.dgvPredavaci = new System.Windows.Forms.DataGridView();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredavaci)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPredavaci
            // 
            this.dgvPredavaci.AllowUserToAddRows = false;
            this.dgvPredavaci.AllowUserToDeleteRows = false;
            this.dgvPredavaci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPredavaci.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPredavaci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPredavaci.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPredavaci.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPredavaci.GridColor = System.Drawing.Color.YellowGreen;
            this.dgvPredavaci.Location = new System.Drawing.Point(39, 114);
            this.dgvPredavaci.Name = "dgvPredavaci";
            this.dgvPredavaci.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPredavaci.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPredavaci.RowHeadersWidth = 50;
            this.dgvPredavaci.Size = new System.Drawing.Size(522, 297);
            this.dgvPredavaci.TabIndex = 0;
            // 
            // lblPretraga
            // 
            this.lblPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.BackColor = System.Drawing.Color.Transparent;
            this.lblPretraga.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretraga.ForeColor = System.Drawing.Color.White;
            this.lblPretraga.Location = new System.Drawing.Point(87, 80);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(76, 20);
            this.lblPretraga.TabIndex = 1;
            this.lblPretraga.Text = "Pretraga:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPretraga.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretraga.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPretraga.Location = new System.Drawing.Point(169, 80);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(179, 26);
            this.txtPretraga.TabIndex = 2;
            this.txtPretraga.Text = "Unesite kriterijum";
            this.txtPretraga.Click += new System.EventHandler(this.txtPretraga_Click);
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikazi.BackColor = System.Drawing.Color.Lime;
            this.btnPrikazi.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazi.Location = new System.Drawing.Point(414, 74);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(94, 34);
            this.btnPrikazi.TabIndex = 4;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // UCSviPredavaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.dgvPredavaci);
            this.Name = "UCSviPredavaci";
            this.Size = new System.Drawing.Size(869, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredavaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPredavaci;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPrikazi;

        public DataGridView DgvPredavaci { get => dgvPredavaci; set => dgvPredavaci = value; }
        public Label LblPretraga { get => lblPretraga; set => lblPretraga = value; }
        public TextBox TxtPretraga { get => txtPretraga; set => txtPretraga = value; }
        public Button BtnPrikazi { get => btnPrikazi; set => btnPrikazi = value; }
    }
}
