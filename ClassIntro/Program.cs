using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 68;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat ";
            kurs4.IzlenmeOrani = 100;

            Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
            //yukardaki kursları bir array e alabiliriz.
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4};

            foreach (var kurs in kurslar)
            {
                //Bu kısım kullanıcı önyüzü
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        }
    }
    class Kurs
    {
        //Sınıflar bir nesnenin farklı türdeki özelliklerinin bir araya geldiği yapılar 
        //class larla tip tanımlarız string gibi int gibi ama farklı bir tip tanımlarız
        //prop yazıp tab+tab yapılır. property nin kısaltması.
        //Bir objenin birden çok özelliği olduğu için class tanımlıyoruz.
        //Örneğin urunler bir classdır. Urunun adı, fiyatı, indirim oranı, image dosayası vardır. 
        //Kume gibidir.
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
        

    }
}
