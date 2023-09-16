namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //Type-safe -- Tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------------");
            }

            Console.WriteLine("------------Metotlar-------------");

            //instance -- örnek
            //encapsulation -- kapsülleme, sen aslında böyle ayrı ayrı yazacağın ve düzensiz olacak bir yapıyı bir düzenin içine sokuyorsun.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Elma", "Yeşil elma", 15, 10);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 36, 1);
            sepetManager.Ekle2("Armut", "Deveci armut", 25, 7);
            sepetManager.Ekle2("Çilek", "Dağ çileği", 30, 4);

        }
    }
}

//Dont repeat yourself - DRY - Clean Code - Best Practice