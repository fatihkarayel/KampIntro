using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //birinci müşteri tanımlıyoruz
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Ahmet";
            musteri1.Soyad = "Demir";
            musteri1.No = 12;
            

            //ikinci müşteriyi tanımlıyoruz
            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Tuna";
            musteri2.Soyad = "Karayel";
            musteri2.No = 98;
            

            MusteriManager musteriManager = new MusteriManager();

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };// müşteriler diziye alınıyor.

            foreach (Musteri musteri in musteriler)
            {
                musteriManager.Ekle(musteri);//dizideki her bir müşteri için DB ye ekleyen metod çağrılıyor.
            }

            //müşteri silme metodu çağrılıyor.
            musteriManager.Sil(musteri1);

            //diziye alınmış müşteriler listelemek için liste formatında metoda gönderiliyor.
            musteriManager.Listele(musteriler);


        }
    }
}
