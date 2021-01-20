using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "A", "B", "C", "D" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler[4] = "E";//Hata verir eklemez
            ////Array ler oluşturdukları sınırlar içinde kalır. bunun dışına çıkmazlar, genişletilemezler.
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);
            // bunun yerine koleksiyonlar kullanılır. C# ve Java da koleksiyonlar yoğunlukla kullanılır .Arrayler pek kullanılmaz

            //List<string> isimler2 = new List<string>();
            //isimler2.Add("Engin"); //şeklinde eklenebilir
            List<string> isimler2 = new List<string>() { "A", "B", "C", "D" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("F"); //bu şekilde listelere ekleme yapılabilir. Ama arraylere yapılamaz.
            Console.WriteLine(isimler2[4]);//ekledikten sonra kontrol ediyoruz. Eklenmişmi diye.
            Console.WriteLine(isimler2[0]);
            

        }
    }
}
