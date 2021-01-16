using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirme Kampı";
            string kurs2 = "Başlangıç için temel kurs";
            string kurs3 = "Java";
            //yukarıdaki gibi tek tek değişkene atanmazlar. onun yerine arrayde tutulur. Bu şekilde her ürünü ayrı bir değişkende kullanmak dinamik olmaz. 

            //Bu tip veriler Array lerde yani dizilerde tutulur.
            //yani tek tek tanımlamak yerine bir dizide tutulur.
            // gerek hayatta kurlarıGetir() şeklinde bir metodla döndürülür.
            string[] kurslar = new string[] { "Yazılım Geliştirme Kampı", "Başlangıç için temel kurs", "Java", "Python","C++" };

            Console.WriteLine("************for başlıyor***************");
            for (int i = 0; i < kurslar.Length; i++) // i++ birer birer artırır i=i+2 yazarsak 2şer 2şer artar. veya i+=2 de yazabiliriz
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("**********foreach başlıyor*************");
            //foreach dizi temelli yapıları tek tek dönmeye yarıyor. Dizilere uygulanır.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("\n");

            Console.WriteLine("************Sayfa Sonu - footer**********");
        }
    }
}
