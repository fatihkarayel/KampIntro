using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //DegerVeReferansTipler Cok önemli
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1); //30
            int[] sayilar1 = new int[] {10,20,30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);//999

            //Sayisal veri tipleri: int, bool, double, decimal, float değer tiplerdir.
            //array, class, interface ler ise referans tiplerdir.
            //int[] array dir. değer tip değildir.

            //deger tip olanlar bellekde stack de gerçekleşiyor.
            //sayi1 = 10 veya sayi2=30 dediğimizde stackde gerçekleşir. 
            //yani okurken sayi1 in değeri eşittir 10 diye okuruz.
            //sayi1 değeri eşittir sayi2 dersen. o an sayi2 nin değerini sayi1 atar. 

            //Referans tipler işlem heap de gerçekleşir.
            //new dediğimizde stackde sayilar1 isimli değer oluşur ama bunun karşılığı olan değer dizini heap da tutulur.
            //new demek bellekde bir adres oluştur demek.

            //değer tiplerde değer atanır. referans tiplerde adres atanır.
        }
    }
}
