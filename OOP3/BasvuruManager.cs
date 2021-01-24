using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //metohod injection yapıyoruz. hangi metodu kullanacağını hangi logger i kullanacağını injection yapıyoruz.
        //soyut halleri var.
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //Basvuran bilgilierini değerlendirme
            //...
            //KonutKrediManager konutKrediManager = new KonutKrediManager(); // bunu yaparsak  Konut kredisine bağımlı olur.
            //konutKrediManager.Hesapla();
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            //yukarıda tek bir kredi seçebiliyor. çünkü başvuru yapacağız. ama burada farklı farklı kredi türlerini seçebilir.
            //gelen kredi listesine göre tek tek hesaplatıyoruz
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}
