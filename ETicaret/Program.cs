using System;

namespace eticaret
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eti Puf
            Product prod1 = new Product();
            prod1.ProductID = 1;
            prod1.ProductName = "Eti Puf";
            prod1.ProductPrice = 1.25;
            prod1.ProductCount = 100;
            prod1.ProductDesc = "Biskuvi üzerine marşmelov";

            //Çikolatalı goflet
            Product prod2 = new Product();
            prod2.ProductID = 2;
            prod2.ProductName = "Ülker Çikolatalı Gofret";
            prod2.ProductPrice = 2;
            prod2.ProductCount = 300;
            prod2.ProductDesc = "Çikolata kaplı çıtır gofret";

            Product[] products = new Product[] { prod1, prod2 };

            Console.WriteLine("**for döngüsü ile**");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName + " fiyatı: " + products[i].ProductPrice);
            }
            Console.WriteLine("\n");
            
            Console.WriteLine("**foreach döngüsü ile**");
            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName + " stok adedi : " + product.ProductCount);
            }
            Console.WriteLine("\n");
            
            Console.WriteLine("**while döngüsü ile**");
            int j= 0;
            while (j<products.Length)
            {
                Console.WriteLine(products[j].ProductName + " açıklaması: " + products[j].ProductDesc);
                j++;
            }
            Console.WriteLine("\n");
            Console.WriteLine("+++++++++  Sayfa Sonu  +++++++++++");
        }

    }
    class Product
    {
        public int ProductID { get; set;}
        public string ProductName { get; set;}
        public double ProductPrice { get; set;}
        public int ProductCount { get; set;}
        public string ProductDesc{get;set;}
    }
}
