namespace ANK15hamburgeruygulama
{
    partial class SiparisEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisEkleme));
            this.pcbResim = new System.Windows.Forms.PictureBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.cbxMenu = new System.Windows.Forms.ComboBox();
            this.lblBoyut = new System.Windows.Forms.Label();
            this.rdbKucuk = new System.Windows.Forms.RadioButton();
            this.rdbOrta = new System.Windows.Forms.RadioButton();
            this.rdbBuyuk = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.gpxBoyut = new System.Windows.Forms.GroupBox();
            this.clbMalzeme = new System.Windows.Forms.CheckedListBox();
            this.lblAdet = new System.Windows.Forms.Label();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.btnSiparisTamamla = new System.Windows.Forms.Button();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResim)).BeginInit();
            this.gpxBoyut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbResim
            // 
            this.pcbResim.Image = ((System.Drawing.Image)(resources.GetObject("pcbResim.Image")));
            this.pcbResim.Location = new System.Drawing.Point(26, 12);
            this.pcbResim.Name = "pcbResim";
            this.pcbResim.Size = new System.Drawing.Size(130, 61);
            this.pcbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbResim.TabIndex = 0;
            this.pcbResim.TabStop = false;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(23, 76);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(74, 13);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "MENÜ SEÇİN";
            // 
            // cbxMenu
            // 
            this.cbxMenu.FormattingEnabled = true;
            this.cbxMenu.Location = new System.Drawing.Point(26, 92);
            this.cbxMenu.Name = "cbxMenu";
            this.cbxMenu.Size = new System.Drawing.Size(121, 21);
            this.cbxMenu.TabIndex = 2;
            this.cbxMenu.SelectedIndexChanged += new System.EventHandler(this.cbxMenu_SelectedIndexChanged);
            // 
            // lblBoyut
            // 
            this.lblBoyut.AutoSize = true;
            this.lblBoyut.Location = new System.Drawing.Point(23, 128);
            this.lblBoyut.Name = "lblBoyut";
            this.lblBoyut.Size = new System.Drawing.Size(89, 13);
            this.lblBoyut.TabIndex = 3;
            this.lblBoyut.Text = "BOYUT SEÇİNİZ";
            // 
            // rdbKucuk
            // 
            this.rdbKucuk.AutoSize = true;
            this.rdbKucuk.Location = new System.Drawing.Point(0, 37);
            this.rdbKucuk.Name = "rdbKucuk";
            this.rdbKucuk.Size = new System.Drawing.Size(56, 17);
            this.rdbKucuk.TabIndex = 4;
            this.rdbKucuk.TabStop = true;
            this.rdbKucuk.Text = "Küçük";
            this.rdbKucuk.UseVisualStyleBackColor = true;
            // 
            // rdbOrta
            // 
            this.rdbOrta.AutoSize = true;
            this.rdbOrta.Location = new System.Drawing.Point(70, 37);
            this.rdbOrta.Name = "rdbOrta";
            this.rdbOrta.Size = new System.Drawing.Size(45, 17);
            this.rdbOrta.TabIndex = 5;
            this.rdbOrta.TabStop = true;
            this.rdbOrta.Text = "Orta";
            this.rdbOrta.UseVisualStyleBackColor = true;
            // 
            // rdbBuyuk
            // 
            this.rdbBuyuk.AutoSize = true;
            this.rdbBuyuk.Location = new System.Drawing.Point(121, 37);
            this.rdbBuyuk.Name = "rdbBuyuk";
            this.rdbBuyuk.Size = new System.Drawing.Size(55, 17);
            this.rdbBuyuk.TabIndex = 6;
            this.rdbBuyuk.TabStop = true;
            this.rdbBuyuk.Text = "Büyük";
            this.rdbBuyuk.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "MALZEME SEÇİN";
            // 
            // gpxBoyut
            // 
            this.gpxBoyut.Controls.Add(this.rdbKucuk);
            this.gpxBoyut.Controls.Add(this.rdbOrta);
            this.gpxBoyut.Controls.Add(this.rdbBuyuk);
            this.gpxBoyut.Location = new System.Drawing.Point(26, 144);
            this.gpxBoyut.Name = "gpxBoyut";
            this.gpxBoyut.Size = new System.Drawing.Size(181, 63);
            this.gpxBoyut.TabIndex = 8;
            this.gpxBoyut.TabStop = false;
            this.gpxBoyut.Text = "groupBox1";
            // 
            // clbMalzeme
            // 
            this.clbMalzeme.FormattingEnabled = true;
            this.clbMalzeme.Location = new System.Drawing.Point(23, 235);
            this.clbMalzeme.Name = "clbMalzeme";
            this.clbMalzeme.Size = new System.Drawing.Size(118, 94);
            this.clbMalzeme.TabIndex = 9;
            this.clbMalzeme.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(12, 365);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(36, 13);
            this.lblAdet.TabIndex = 10;
            this.lblAdet.Text = "ADET";
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(62, 358);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(120, 20);
            this.nudAdet.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "SİPARİŞ EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.Location = new System.Drawing.Point(311, 404);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(28, 13);
            this.lblToplamFiyat.TabIndex = 13;
            this.lblToplamFiyat.Text = "0,00";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(208, 404);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(97, 13);
            this.lblToplam.TabIndex = 14;
            this.lblToplam.Text = "TOPLAM TUTAR :";
            // 
            // btnSiparisTamamla
            // 
            this.btnSiparisTamamla.Location = new System.Drawing.Point(462, 388);
            this.btnSiparisTamamla.Name = "btnSiparisTamamla";
            this.btnSiparisTamamla.Size = new System.Drawing.Size(214, 29);
            this.btnSiparisTamamla.TabIndex = 15;
            this.btnSiparisTamamla.Text = "SİPARİŞİ TAMAMLA";
            this.btnSiparisTamamla.UseVisualStyleBackColor = true;
            this.btnSiparisTamamla.Click += new System.EventHandler(this.btnSiparisTamamla_Click);
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(235, 21);
            this.lstUrunler.MultiColumn = true;
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(526, 238);
            this.lstUrunler.TabIndex = 16;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // SiparisEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 520);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.btnSiparisTamamla);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lblToplamFiyat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.clbMalzeme);
            this.Controls.Add(this.gpxBoyut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBoyut);
            this.Controls.Add(this.cbxMenu);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.pcbResim);
            this.Name = "SiparisEkleme";
            this.Text = "SiparisEkleme";
            this.Load += new System.EventHandler(this.SiparisEkleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbResim)).EndInit();
            this.gpxBoyut.ResumeLayout(false);
            this.gpxBoyut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbResim;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.ComboBox cbxMenu;
        private System.Windows.Forms.Label lblBoyut;
        private System.Windows.Forms.RadioButton rdbKucuk;
        private System.Windows.Forms.RadioButton rdbOrta;
        private System.Windows.Forms.RadioButton rdbBuyuk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpxBoyut;
        private System.Windows.Forms.CheckedListBox clbMalzeme;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblToplamFiyat;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button btnSiparisTamamla;
        private System.Windows.Forms.ListBox lstUrunler;
    }
}