using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " "+musteri.Soyad+" " + "eklendi");
            Console.WriteLine("\n");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + "silindi");
            Console.WriteLine("\n");
        }
        public void Listele(Musteri[] musteriler)
        {
            
            Console.WriteLine("Müşteri listesi");
            foreach (Musteri musteri in musteriler)
            {
               Console.WriteLine(musteri.Ad + " " + musteri.Soyad );
            }
            Console.WriteLine("\n");

        }
    }
}
