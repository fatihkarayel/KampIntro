using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //Mobilya
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //Aşağıdaki şekilde de yazılabilir.
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            //class lar pascal case yani ilk harfler büyük
            //degiskenler ise camelCase yani ilk harf küçük sonraki harf büyük yazılır.
            //Bu çok önemli bir kural dikkat edilmesi gerekir
            ProductManager productManager = new ProductManager();
            //heap da oluşabilmesi için new lemen gerekir.
            //sol taraf stack - sağ taraf heap
            productManager.Add(product1);
            //int double, bool değer tip dir 
            //diziler class abstract class interface referans tipdir. Atamalar referans numarası üzerinden gider.



        }
    }
}
