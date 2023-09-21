namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bellekte Stack   Bellekte Heap bölümü
            Product product1 = new Product
            {
                Id = 1,
                CategoryId= 2,
                ProductName = "Telefon",
                UnitPrice = 64999,
                UnitsInStock = 250
            };


            //PascalCase   //camelCase
            //Case sensitive
            //Bellekte Stack bölümü         Bellekte Heap bölümü
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

        }
    }
}