using System;

namespace RefNOut
{
    class Program
    {
        static void Main(string[] args)
        {
            //Out keyword için örnek
            //Indirim oranı kullanıcının statüsüne göre değiştiği için bunu metod içinde belirliyoruz.
            double dsRate= DiscountRate(out double dcr);
            Console.WriteLine("Eğer Vip user ise indirim oranı %30 değilse %25: "+dsRate);

            //Ref keyword için örnek
            //Mevcut sepet adedi, bir metodla değişiyor ve bundan sonra hep bu değer geçerli hale geliyor.
            int basketCount = 10;
            Console.WriteLine("ilk faz: "+basketCount);
            AddMoreProduct(ref basketCount);
            Console.WriteLine("ikinci faz ( Sepet adedi artık yeni değer.): "+basketCount) ;
        }
        static double DiscountRate(out double discountRate)
        {
            string user = "VipUser";//Vip User, user değişkenine atanıyor.
            discountRate = 0.25; //Standart iskonto oranı discountRate değişkenine atanıyor.
            double discountRateVip = 0.05;//Vip user olan kullanıcılar için ilave iskonto oranı tanımlanıyor.
            double result = user == "VipUser" ? discountRate + discountRateVip : discountRate;//Eğer kullanıcı vip user ise ilave iskonto ekleniyor.
            return result;
        }
        static int AddMoreProduct(ref int basketCount)
        {
            basketCount+=1; //kullanıcının farklı bir sayfada sepetdeki ürün adedini 1 artırdığı simüle edildi.
            return basketCount;
        }
    }
}
