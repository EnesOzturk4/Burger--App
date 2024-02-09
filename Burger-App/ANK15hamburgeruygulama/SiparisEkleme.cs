using ANK15hamburgeruygulama.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace ANK15hamburgeruygulama
{

    public partial class SiparisEkleme : Form
    {
        double toplamTutar = 0;
        public static List<Siparis> siparisler=new List<Siparis>();

        Siparis siparis;
        public SiparisEkleme()
        {
            InitializeComponent();

            foreach (var item in siparisler)
                toplamTutar += item.ToplamTutar;

            lblToplamFiyat.Text = toplamTutar.ToString();
            cbxMenu.Items.AddRange(menu.ToArray());



            clbMalzeme.Items.AddRange(extras.ToArray());
         
            lstUrunler.Items.AddRange(siparisler.ToArray());
            


        }
        public static List<Menuu> menu = new List<Menuu>()
        {
            new Menuu{Adi="Super King " ,Fiyat=150},
            new Menuu{Adi="Chicken Menü" ,Fiyat=300},
            new Menuu{Adi="Mega Queen" ,Fiyat=300},
            new Menuu{Adi="Mega King" ,Fiyat=300},
            new Menuu{Adi="Big King" ,Fiyat=300},


        };


     public static   List<ExtraMalzemeclass> extras = new List<ExtraMalzemeclass>()
        {
            new ExtraMalzemeclass{Ad="Ketçap",Fiyat=4},
            new ExtraMalzemeclass{Ad="Mayonez",Fiyat=5 },
            new ExtraMalzemeclass{Ad="Ranch",Fiyat=8},
            new ExtraMalzemeclass{Ad="BBQ",Fiyat=9},
            new ExtraMalzemeclass{Ad="Hardal",Fiyat=9},
            new ExtraMalzemeclass{Ad="Buffalo",Fiyat=7}


        };




    
        
        



        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SiparisEkleme_Load(object sender, EventArgs e)
        {


    
            

            


        }

        private void cbxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
     
        private void button1_Click(object sender, EventArgs e)
        {
   

            Siparis siparis=new Siparis();  

         
           
            siparis.MenuAdi = (Menuu)cbxMenu.SelectedItem;

            siparis.Adet = (int)nudAdet.Value;
            siparis.ToplamTutar+= (int)(siparis.Adet * ((Menuu)cbxMenu.SelectedItem).Fiyat);

           
           
         

            for (int i = 0; i < clbMalzeme.Items.Count; i++)
            {
                if (clbMalzeme.GetItemChecked(i) == true)
                {
                    siparis.extramalzemeler.Add((ExtraMalzemeclass)clbMalzeme.Items[i]);
                }
            }


            if (rdbBuyuk.Checked)
            {
                siparis.MenuAdi.Boyut = Boyut.buyuk;
                siparis.ToplamTutar *= 1.5;

            }
            else if (rdbOrta.Checked)
            {
                siparis.MenuAdi.Boyut = Boyut.orta;
                siparis.ToplamTutar *= 1.25;
            }
            else if (rdbKucuk.Checked)
            {
                siparis.MenuAdi.Boyut = Boyut.kucuk;
            }
            else
                MessageBox.Show("Lütfen Boyut Seçiniz !!");





            foreach (var item in siparis.extramalzemeler)
                    siparis.ToplamTutar += item.Fiyat;

                
            

           toplamTutar += siparis.ToplamTutar;
           lblToplamFiyat.Text = toplamTutar.ToString();
           siparisler.Add(siparis);
           lstUrunler.Items.Add(siparis);  
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show($"siparişi onaylıyormusunuz toplam tutar:{lblToplamFiyat.Text} ","Sipariş Onayı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result==DialogResult.Yes)
            {
                lstUrunler.Items.Clear();
                foreach (var item in siparisler)
                {


                    item.OnaylandiMi = true;


                }
             
            }
            else
            {
                MessageBox.Show("Sipariş onaylanmadı");
            }
        }
    }
}
