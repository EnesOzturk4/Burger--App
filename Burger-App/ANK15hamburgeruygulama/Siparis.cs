using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK15hamburgeruygulama.Classlar
{
    public class Siparis
    {
        public Menu MenuAdi { get; set; }
        public int Adet { get; set; }
        public int ToplamTutar { get; set; }
        public  List<ExtraMalzeme> extramalzemeler=new List<ExtraMalzeme> ();


    
    }
}
