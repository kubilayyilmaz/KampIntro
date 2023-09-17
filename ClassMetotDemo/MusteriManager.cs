using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi. " + musteri.Ad);
        }

        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Güncellendi. " + musteri.Ad);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi. " + musteri.Ad);
        }

        public void Listele()
        {
            Console.WriteLine("Müşteriler Listelendi.");
        }
    }
}