using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfaceler birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullnırız.
            //Krediler böyledir. Hepsinde hesaplama yöntemi farklı ama bir hesapla metodu vardır.

            //interfaceler onu inherit eden clasın referansını tutabilirler. Kanıtı aşağıda.
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager ihtiyacKrediManager2 = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();
            //ihtiyacKrediManager2.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager tasitKrediManager2 = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            //tasitKrediManager2.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager konutKrediManager2 = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            //konutKrediManager2.Hesapla();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            List<ILoggerService> loggers = new List<ILoggerService> () { new FileLoggerService(), new DatabaseLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager2, loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager2, tasitKrediManager2};
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
