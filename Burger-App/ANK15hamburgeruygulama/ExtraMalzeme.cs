using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ANK15hamburgeruygulama.Classlar;
namespace ANK15hamburgeruygulama
{
    public partial class ExtraMalzeme : Form
    { 
        public ExtraMalzeme()
        {
            InitializeComponent();
        }

        private void btnExtraMalzemeKaydet_Click(object sender, EventArgs e)
        {
         
            ExtraMalzemeclass extraMalzeme= new ExtraMalzemeclass();
            extraMalzeme.Ad = txtEkstraMalzeme.Text;
            extraMalzeme.Fiyat = (int)nudFiyat.Value;
            SiparisEkleme.extras.Add(extraMalzeme);
            MessageBox.Show("Ekstra Malzeme Başarıyla Eklenmiştir.");
            
        }

        private void ExtraMalzeme_Load(object sender, EventArgs e)
        {

        }
    }
}
