using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //T özel bir tip olacağını bir tip olacağını gösterir. generic bir tip belirtmek için kullanırız. programcı bu class ı new lerken hangi tip olacağını söylerse o veri tip olur.
    {
        T[] items; //T generic tipli array bir items array i oluşturduk.
        //constractor
        //new lediğin anda çalışan bloğa constractor denir
        public MyList()
        {
            items = new T[0]; //oluşturduğumuz array in eleman sayısını sıfır olarak inilize ettik
        }
        public void Add(T item)
        {
            T[] tempArray = items;//Array deki önceki veriler newlendiğinde uçacağı için mevcut verileri geçici bir array e alıyoruz.
            items = new T[items.Length + 1];// Array i new liyor ve uzunluğunu artırdık.
            //aşağıda ise geçici arrayde ki verileri new lenmiş olan yeni arrray'e gönderiyoruz.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;//methoda gönderilen item ı, yeni array in sonuncu elemanı olarak ekliyoruz.
        }
        public int Length //array in uzunluğunu okumak için bir getter yaptım.
        {
            get { return items.Length; }
        }
        public T[] Items //array i listemek için bir getter yaptım.
        {
            get { return items; }
        }

    }
}
