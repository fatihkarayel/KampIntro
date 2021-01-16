using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //class ın örneğini oluşturuyoruz.
            //clasdan bir tanımlama yapmak gerektiğinde new yaparız.
            
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };
            
            foreach (Urun urun in urunler)
            {

                Console.WriteLine("Adi: "+urun.Adi);
                Console.WriteLine("Fiyatı: " + urun.Fiyati);
                Console.WriteLine("Aciklama: " + urun.Aciklama);
                Console.WriteLine("---------------------");
            }

            Console.WriteLine("------------Metodlar------------------");
            SepetManager sepetManager = new SepetManager(); //class ın instance ı oluşturuz
            //SepetManager clasında sepet'le ile ilgili işlemleri topladık. Örneğin burda Sepet'e ekle metodunu yazdık.
            //encapsulation yapmak gerekiyor. yani urunun prop una yeni bir prop daha ekleyince hiç bir yer patlamıyor.
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 8);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 5);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuz", 12, 80);
        }
    }
}
