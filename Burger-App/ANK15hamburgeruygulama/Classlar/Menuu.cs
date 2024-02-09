using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK15hamburgeruygulama.Classlar
{
    public class Menuu
    {
        public List<ExtraMalzemeclass>extramalzeme=new List<ExtraMalzemeclass>();

        public string Adi { get; set; }
        public double Fiyat { get; set; }

        public Boyut Boyut { get; set; }
        public override string ToString()
        {
            return Adi ;
        }
    }
}
