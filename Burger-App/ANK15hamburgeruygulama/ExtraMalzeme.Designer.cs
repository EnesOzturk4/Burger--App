namespace ANK15hamburgeruygulama
{
    partial class ExtraMalzeme
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblExtraMalzemeAdı = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.txtEkstraMalzeme = new System.Windows.Forms.TextBox();
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            this.btnExtraMalzemeKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EKSTRA MALZEME BİLGİLERİ";
            // 
            // lblExtraMalzemeAdı
            // 
            this.lblExtraMalzemeAdı.AutoSize = true;
            this.lblExtraMalzemeAdı.Location = new System.Drawing.Point(12, 57);
            this.lblExtraMalzemeAdı.Name = "lblExtraMalzemeAdı";
            this.lblExtraMalzemeAdı.Size = new System.Drawing.Size(100, 13);
            this.lblExtraMalzemeAdı.TabIndex = 1;
            this.lblExtraMalzemeAdı.Text = "Ekstra Malzeme Adı";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(12, 81);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(31, 13);
            this.lblFiyat.TabIndex = 2;
            this.lblFiyat.Text = "Fiyatı";
            // 
            // txtEkstraMalzeme
            // 
            this.txtEkstraMalzeme.Location = new System.Drawing.Point(118, 54);
            this.txtEkstraMalzeme.Name = "txtEkstraMalzeme";
            this.txtEkstraMalzeme.Size = new System.Drawing.Size(100, 20);
            this.txtEkstraMalzeme.TabIndex = 3;
            // 
            // nudFiyat
            // 
            this.nudFiyat.Location = new System.Drawing.Point(118, 81);
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(120, 20);
            this.nudFiyat.TabIndex = 4;
            // 
            // btnExtraMalzemeKaydet
            // 
            this.btnExtraMalzemeKaydet.Location = new System.Drawing.Point(118, 118);
            this.btnExtraMalzemeKaydet.Name = "btnExtraMalzemeKaydet";
            this.btnExtraMalzemeKaydet.Size = new System.Drawing.Size(174, 23);
            this.btnExtraMalzemeKaydet.TabIndex = 5;
            this.btnExtraMalzemeKaydet.Text = "EKSTRA MALZEMEYİ KAYDET";
            this.btnExtraMalzemeKaydet.UseVisualStyleBackColor = true;
            this.btnExtraMalzemeKaydet.Click += new System.EventHandler(this.btnExtraMalzemeKaydet_Click);
            // 
            // ExtraMalzeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExtraMalzemeKaydet);
            this.Controls.Add(this.nudFiyat);
            this.Controls.Add(this.txtEkstraMalzeme);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblExtraMalzemeAdı);
            this.Controls.Add(this.label1);
            this.Name = "ExtraMalzeme";
            this.Text = "ExtraMalzeme";
            this.Load += new System.EventHandler(this.ExtraMalzeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExtraMalzemeAdı;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox txtEkstraMalzeme;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.Button btnExtraMalzemeKaydet;
    }
}