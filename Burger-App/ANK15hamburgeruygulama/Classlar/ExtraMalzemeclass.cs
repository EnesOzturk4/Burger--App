using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANK15hamburgeruygulama.Classlar
{
    public class ExtraMalzemeclass
    {
        public string Ad { get; set; }
        public double Fiyat { get; set; }

        public override string ToString()
        {
            return Ad; 
        }

    }
}
