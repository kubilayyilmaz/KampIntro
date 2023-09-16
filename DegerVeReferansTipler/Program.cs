namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 70;
            //sayi1 ?? = 30
            //int, decimal, float, double, bool veri tipleri = değer tip
            //Belleğin sadece stack bölümünde ismiyle tutulurlar.

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300};

            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            //sayilar1[0] ?? = 999
            //array, class, interface = referans tip
            //Belleğin stack bölümünde ismiyle, heap bölümünde değerleriyle tutulurlar.


            //Stack                 Heap
            //sayilar1 (101)        [10, 20, 30] (101)
            //sayilar2 (102)        [100, 200, 300] (102)
            //sayilar1 = sayilar2 dediğimiz zaman sayilar1'in adresi 102 olur.



        }
    }
}