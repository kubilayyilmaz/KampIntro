namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs()
            {
                KursAdi = "C# Geliştirme Kursu",
                Egitmen = "Engin Demiroğ",
                IzlenmeOrani = 76
            };

            Kurs kurs2 = new Kurs()
            {
                KursAdi = "Java Geliştirme Kursu",
                Egitmen = "Kubilay Yılmaz",
                IzlenmeOrani = 80
            };

            Kurs kurs3 = new Kurs()
            {
                KursAdi = "C++ Geliştirme Kursu",
                Egitmen = "Kerem Varış",
                IzlenmeOrani = 97
            };



        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}