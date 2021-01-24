using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //eğer bir nesnede bir değer o nesneye ait değilmiş gibi duruyorsa orada soyutlama hatası yapıyorsun demektir.
    //Bu nedenla aşağıdaki gib hem tüzel hem gerçek kişiler aynı class da yaratılması hatalı olur.
    class Musteri
    {
        //class lar ya operasyon yada özellik tutarlar aynı yerde tutmayız. farklı classlarda tutarız
        public int Id { get; set; }
        public string MusteriNo { get; set; }

        //sayılardan oluşur long yapmak yerine string yapmanın nedeni eğer bir veri üzerinde matematiksel işlem yapmıyorsan bunlar metinsel olarak planlanmalı. Farklı yazılım ortamlarda bunlar değişebiliyor. Veri uyumsuzluğu olmasın diye string tanımlıyoruz.

    }
}
