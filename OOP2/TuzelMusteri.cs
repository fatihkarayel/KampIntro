using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Corporate
    class TuzelMusteri:Musteri
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }//sayılardan oluşur long yapmak yerine string yapmanın nedeni eğer bir veri üzerinde matematiksel işlem yapmıyorsan bunlar metinsel olarak planlanmalı. Farklı yazılım ortamlarda bunlar değişebiliyor. Veri uyumsuzluğu olmasın diye string tanımlıyoruz.
    }
}
