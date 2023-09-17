namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Kubilay";
            musteri1.Soyad = "Yılmaz";
            musteri1.TcKimlikNo = "141411231231";


            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Aslıhan";
            musteri2.Soyad = "Yılmaz";
            musteri2.TcKimlikNo = "124128132121";


            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Kıvanç";
            musteri3.Soyad = "Yılmaz";
            musteri3.TcKimlikNo = "481212412312";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3};
            
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            musteriManager.Guncelle(musteri2);

            musteriManager.Sil(musteri3);

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
            }

            musteriManager.Listele();
        }
    }
}