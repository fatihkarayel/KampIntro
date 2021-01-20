using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //T özel bir tip olacağını generic bir tip belirtmek için kullanırız. programcı new lerken onu alır.
    {
        T[] items;
        //constractor
        //new lediğin anda çalışan bloğa constactor denir
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;//öncekiler newleneceği için uçacak. o yüzden mevcut verileri geçici bir array de tutuyoruz
            items = new T[items.Length + 1];
            //aşağıda ise geçici arrayde ki verileri new lenmiş olan arrray'e gönderiyoruz.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;//yukardan gelen item array in sonuncu elemanı olarak ekleniyor.
        }
    }
}
