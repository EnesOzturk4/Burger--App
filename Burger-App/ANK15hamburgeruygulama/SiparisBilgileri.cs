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
    public partial class SiparisBilgileri : Form
    {
        Siparis siparis;
        public SiparisBilgileri()
        {
            InitializeComponent();
         

            foreach (var item in SiparisEkleme.siparisler)
            {
           
                if(item.OnaylandiMi)
                    lbxtumSiparisler.Items.Add(item);
                
            }
          
        }
     
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SiparisBilgileri_Load(object sender, EventArgs e)
        {
            lblSiparişSayısı.Text =SiparisEkleme.siparisler.Count.ToString();


            lblcirog.Text = SiparisEkleme.siparisler.Where(s => s.OnaylandiMi).Sum(s => s.ToplamTutar).ToString();




            double ekstramalzemeGeliri = 0;
            lblSatılanUrunAdedi.Text = SiparisEkleme.siparisler.Where(s => s.OnaylandiMi).Sum(s=>s.Adet).ToString();
            foreach (var item in SiparisEkleme.siparisler.Where(s => s.OnaylandiMi))
            {
                foreach (var item2 in item.extramalzemeler)
                {
                    ekstramalzemeGeliri+= item2.Fiyat;
                    lblekstraMalzemeGeliri.Text=ekstramalzemeGeliri.ToString();


                }
            }
            
          

        }
    }
}
