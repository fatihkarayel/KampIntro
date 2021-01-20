using MernisServiceReference;
using System;

namespace TcknControl
{
    class Program
    {
        //Bu işlem için öncelikle connected servislere bir micro service olan  Mernis Servisi eklenmelidir.
        //https://tckimlik.nvi.gov.tr/ adresinde aşağıdaki web servislerin linki alınır.

        //https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx
        //https://tckimlik.nvi.gov.tr/Service/KPSPublicV2.asmx
        //https://tckimlik.nvi.gov.tr/Service/KPSPublicYabanciDogrula.asmx

        //Proje üzerinde sağ klik> Add> Connected Service yap.
        //WebService > Microsoft WCF Web Service Reference Provider seç
        //açılan pencereden Service Enpoint kısmında URL ve Namespace kısımlarını doldur Next yap.

        //Data Collection kısmında Collection Type: Sistem.Collection.Generic.List seç.
        //Dictionary Collection Type kısmında: Sistem.Collection.Generic.Dictionary seç.
        //finish


        static void Main(string[] args)
        {
            bool sonuc = CheckCitizen(12345, "FATİH", "KARAYEL", 1984);
            Console.WriteLine(sonuc);
        }
        static bool CheckCitizen(long tckn, string ad, string soyad, int dogumYili)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(tckn, ad, soyad, dogumYili))).Result.Body.TCKimlikNoDogrulaResult;
            //return client.TCKimlikNoDogrulaAsync(1234, "FATİH", "KARAYEL", 1984);
        }
    }
}
