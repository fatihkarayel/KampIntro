using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soyutlama nesne yönelimli programlam fark yaratır.
            //abstract snıfları ve nesneler iherkes bilir ama gerçek hayata uygulamada sıkıntı vardır.
            //teknikleri bilir, syntax ı bilir ama nerede uygulayacağın bilmez.

            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Fatih";
            //musteri1.Soyadi = "Karayel";
            //musteri1.Id = 1;
            //musteri1.TcNo = "1111111111";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "?";

            //Gerçek Müşteri- Tüzel Müşteri iki tane nesne var. bunlar birbirine benziyor diye birbirinin yerine asla kullanılamaz.
            //SOLID pronsiplerinden L harfi bunu uygulamamızı söyler.

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Id = 1;
            musteri1.Adi = "Fatih";
            musteri1.Soyadi = "Karayel";
            musteri1.TcNo = "111111";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "ABC A.Ş.";
            musteri2.VergiNo = "987654";

            Musteri musteri3= new GercekMusteri(); //Musteri tipinde musteri3 yaratıp Gercekmusteri sınıfını çağırıyoruz.
            Musteri musteri4 = new TuzelMusteri(); //Musteri tipinde musteri4 yaratıpTuzelmusteri sınıfını çağırıyoruz.
            //Bu syade biz bunları Musteri olarak Ekle() metoduna gönderebiliyoruz.
            //Base sınıf referans tutucudur.

            //Musteri clasıı hem gerçek müşterinin hem tüzel müşterinin referansını tutabiliyor.
            //Bu sayede Manager sınıfında iki classı da Musteri olarak gönderebiliyorum.
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
        }
    }
}
