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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        private void FormGoster(Form gosterilecekForm)
        {
            gosterilecekForm.StartPosition = 0;

            if (!MdiChildren.Contains(gosterilecekForm))
                gosterilecekForm.MdiParent = this;

            //bu formun çocukları içerisinde dönelim,istenileni görünür yapalım
            foreach (var altForm in MdiChildren)
            {
                if (gosterilecekForm.Text==altForm.Text)
                {

                    altForm.Show();

                
                }
                else
                {
                    altForm.Close();
                }
            }
           

        }
        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new SiparisEkleme());
        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new SiparisBilgileri());

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new MenuEkleme());
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new ExtraMalzeme());
        }
    }
}
