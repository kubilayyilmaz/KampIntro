using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
     class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi. " + urun.UrunAdi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyati, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi. " + urunAdi);
        }
    }
}
