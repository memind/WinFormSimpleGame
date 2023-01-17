namespace Dungeon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBaslangicIsim = new System.Windows.Forms.Label();
            this.lblBaslangicTur = new System.Windows.Forms.Label();
            this.lblBaslangicSinif = new System.Windows.Forms.Label();
            this.txtBaslangicAd = new System.Windows.Forms.TextBox();
            this.cmbBaslangicTur = new System.Windows.Forms.ComboBox();
            this.cmbBaslangicSinif = new System.Windows.Forms.ComboBox();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBaslangicIsim
            // 
            this.lblBaslangicIsim.AutoSize = true;
            this.lblBaslangicIsim.Location = new System.Drawing.Point(27, 49);
            this.lblBaslangicIsim.Name = "lblBaslangicIsim";
            this.lblBaslangicIsim.Size = new System.Drawing.Size(94, 20);
            this.lblBaslangicIsim.TabIndex = 0;
            this.lblBaslangicIsim.Text = "Karakter Adi:";
            // 
            // lblBaslangicTur
            // 
            this.lblBaslangicTur.AutoSize = true;
            this.lblBaslangicTur.Location = new System.Drawing.Point(21, 82);
            this.lblBaslangicTur.Name = "lblBaslangicTur";
            this.lblBaslangicTur.Size = new System.Drawing.Size(100, 20);
            this.lblBaslangicTur.TabIndex = 0;
            this.lblBaslangicTur.Text = "Karakter Turu:";
            // 
            // lblBaslangicSinif
            // 
            this.lblBaslangicSinif.AutoSize = true;
            this.lblBaslangicSinif.Location = new System.Drawing.Point(17, 116);
            this.lblBaslangicSinif.Name = "lblBaslangicSinif";
            this.lblBaslangicSinif.Size = new System.Drawing.Size(104, 20);
            this.lblBaslangicSinif.TabIndex = 0;
            this.lblBaslangicSinif.Text = "Karakter Sinifi:";
            // 
            // txtBaslangicAd
            // 
            this.txtBaslangicAd.Location = new System.Drawing.Point(138, 46);
            this.txtBaslangicAd.Name = "txtBaslangicAd";
            this.txtBaslangicAd.Size = new System.Drawing.Size(151, 27);
            this.txtBaslangicAd.TabIndex = 0;
            // 
            // cmbBaslangicTur
            // 
            this.cmbBaslangicTur.FormattingEnabled = true;
            this.cmbBaslangicTur.Location = new System.Drawing.Point(138, 79);
            this.cmbBaslangicTur.Name = "cmbBaslangicTur";
            this.cmbBaslangicTur.Size = new System.Drawing.Size(151, 28);
            this.cmbBaslangicTur.TabIndex = 1;
            // 
            // cmbBaslangicSinif
            // 
            this.cmbBaslangicSinif.FormattingEnabled = true;
            this.cmbBaslangicSinif.Location = new System.Drawing.Point(138, 113);
            this.cmbBaslangicSinif.Name = "cmbBaslangicSinif";
            this.cmbBaslangicSinif.Size = new System.Drawing.Size(151, 28);
            this.cmbBaslangicSinif.TabIndex = 2;
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(27, 176);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(107, 48);
            this.btnBasla.TabIndex = 3;
            this.btnBasla.Text = "BASLA";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(182, 176);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(107, 48);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "CIKIS";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 254);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.cmbBaslangicSinif);
            this.Controls.Add(this.cmbBaslangicTur);
            this.Controls.Add(this.txtBaslangicAd);
            this.Controls.Add(this.lblBaslangicSinif);
            this.Controls.Add(this.lblBaslangicTur);
            this.Controls.Add(this.lblBaslangicIsim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBaslangicIsim;
        private Label lblBaslangicTur;
        private Label lblBaslangicSinif;
        private TextBox txtBaslangicAd;
        private ComboBox cmbBaslangicTur;
        private ComboBox cmbBaslangicSinif;
        private Button btnBasla;
        private Button btnCikis;
    }
}