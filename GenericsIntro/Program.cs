namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();

            isimler.Add("Kubilay");

            Console.WriteLine(isimler.Length);

            isimler.Add("Aslıhan");

            Console.WriteLine(isimler.Length);
        }
    }
}