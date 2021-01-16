using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun
    {
        //Bir urunun urun olabilmesi için çeşitli özellikleri barındırması gerkir. Bu özellikleri classlarda tanımlarız.
        //Urunu anlatan veri tipleri oluşturuyoruz.
        //property-özellikleri
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }

    }
}
