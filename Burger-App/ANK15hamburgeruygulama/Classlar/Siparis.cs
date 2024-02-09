using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK15hamburgeruygulama.Classlar
{
    public class Siparis
    {  public List<ExtraMalzemeclass> extramalzemeler = new List<ExtraMalzemeclass>();
        public Menuu MenuAdi { get; set; }
        public int Adet { get; set; }
        public double ToplamTutar { get; set; }

        public bool OnaylandiMi { get; set; }

        // public List<ExtraMalzemeclass> extramalzemeler { get; set; } = new();

        public override string ToString()

        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Adet + " x " + MenuAdi.Adi + " Menü " + MenuAdi.Boyut +" menü Fiyatı "+ ToplamTutar.ToString());

            sb.AppendLine(" Ekstra Malzemeler: ");

            foreach (var item in extramalzemeler)

                sb.AppendLine(item.Ad);

            return sb.ToString();

        }

    }
}
