using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //void Ne işe yarar?
        //void olan metodlar geriye 
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
        public void Delete(Product product)
        {

        }

       
    }
}
