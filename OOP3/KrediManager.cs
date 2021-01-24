using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager// class ismini interface olarak değiştirdik.
    {
        //interfaceler I harfi ile başlatılır. Okunurluğu artırmak için
        //birbirinin alternatifi olmayan durumlarda base class yerine interface yaparız. Çünkü burada hesapla metodu bir anlam ifade etmez.
        //interface ler birer şablondur. miras alan sınıflar bu şablona uymak zorundalar.
        //interface ler genellikle operasyonel metodlarda kullanılır.
        void Hesapla(); //burda metoddaki gibi süslü parantez yok.
        void BiseyYap();

    }
}
