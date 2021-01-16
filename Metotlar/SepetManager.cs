using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention isimlendirme kuralı
        //parametre de verebiliriz. Boş da verebiliriz.
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler! "+ urun.Adi +" Sepete Eklendi.");
        }
        //yukarıdaki tarz class ile kullanım encapsulation demek.
        //aşağıdaki gibi dağınık yapılarda yeni bir şey gelince her taraf patlar.
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stok)//Bu kullanım hatalı bir kullanım sakın yapma
        {
            Console.WriteLine("Tebrikler! " + urunAdi + " Sepete Eklendi.");
        }
    }
}
