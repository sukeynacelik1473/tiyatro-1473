using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiyatro1
{
    internal class Tiyatro
    {
        public string Oyun { get; set; }
        public string Sahne { get; set; }
        public DateTime KayitTarih { get; set; }
        public int Sure { get; set; }
        public int Fiyat { get; set; }
        public bool Muzikal { get; set; }

        public Tiyatro(string oyun, string sahne, DateTime kayitTarih, int sure, int fiyat, bool muzikal)
        {
            Oyun = oyun;
            Sahne = sahne;
            KayitTarih = kayitTarih;
            Sure = sure;
            Fiyat = fiyat;
            Muzikal = muzikal;
        }   
    }
}
