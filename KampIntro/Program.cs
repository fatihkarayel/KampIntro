using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety tip güvenliği.
            //sonunda noktalı virgül zorunlu.
            //Do not repeat yourself - kendini tekrarlama.
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000; //
            double faizOrani = 1.45; // ondalık ayraç nokta ile yazılır
            double dolarDun = 7.35;
            double dolarBugun = 7.35;
            bool sistemeGirisYapmisMi = true;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Dolar Düşmüş.");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Dolar Artmış.");
            }
            else
            {
                Console.WriteLine("Değişmedi.");
            }

            
            if (sistemeGirisYapmisMi==true) //if yazdıktan sonra 2 kez tab tuşuna peşpeşe basın.
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            

        }
    }
}
