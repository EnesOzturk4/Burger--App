namespace ANK15hamburgeruygulama
{
    partial class MenuEkleme
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
            this.lblMenuAdi = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.tbxMenu = new System.Windows.Forms.TextBox();
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            this.btnMenuKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuAdi
            // 
            this.lblMenuAdi.AutoSize = true;
            this.lblMenuAdi.Location = new System.Drawing.Point(12, 51);
            this.lblMenuAdi.Name = "lblMenuAdi";
            this.lblMenuAdi.Size = new System.Drawing.Size(52, 13);
            this.lblMenuAdi.TabIndex = 0;
            this.lblMenuAdi.Text = "Menü Adı";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(12, 77);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(31, 13);
            this.lblFiyat.TabIndex = 1;
            this.lblFiyat.Text = "Fiyatı";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(12, 27);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(93, 13);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "MENÜ BİLGİLERİ";
            // 
            // tbxMenu
            // 
            this.tbxMenu.Location = new System.Drawing.Point(64, 44);
            this.tbxMenu.Name = "tbxMenu";
            this.tbxMenu.Size = new System.Drawing.Size(100, 20);
            this.tbxMenu.TabIndex = 3;
            // 
            // nudFiyat
            // 
            this.nudFiyat.Location = new System.Drawing.Point(64, 75);
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(100, 20);
            this.nudFiyat.TabIndex = 4;
            this.nudFiyat.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // btnMenuKaydet
            // 
            this.btnMenuKaydet.Location = new System.Drawing.Point(64, 101);
            this.btnMenuKaydet.Name = "btnMenuKaydet";
            this.btnMenuKaydet.Size = new System.Drawing.Size(100, 36);
            this.btnMenuKaydet.TabIndex = 5;
            this.btnMenuKaydet.Text = "MENÜYÜ KAYDET";
            this.btnMenuKaydet.UseVisualStyleBackColor = true;
            this.btnMenuKaydet.Click += new System.EventHandler(this.btnMenuKaydet_Click);
            // 
            // MenuEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenuKaydet);
            this.Controls.Add(this.nudFiyat);
            this.Controls.Add(this.tbxMenu);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblMenuAdi);
            this.Name = "MenuEkleme";
            this.Text = "MenuEkleme";
            this.Load += new System.EventHandler(this.MenuEkleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuAdi;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.TextBox tbxMenu;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.Button btnMenuKaydet;
    }
}