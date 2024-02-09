using ANK15hamburgeruygulama.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANK15hamburgeruygulama
{
    public partial class MenuEkleme : Form
    {
        public MenuEkleme()
        {
            InitializeComponent();

        }

        private void MenuEkleme_Load(object sender, EventArgs e)
        {

        }

        private void btnMenuKaydet_Click(object sender, EventArgs e)
        {
            Menuu menu= new Menuu();
            menu.Adi = tbxMenu.Text;
            menu.Fiyat = (int)nudFiyat.Value;
            SiparisEkleme.menu.Add(menu);
            MessageBox.Show("Menü başarıyla eklenmiştir.");
        }
    }
}
