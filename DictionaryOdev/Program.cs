using System;

namespace DictionaryOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryManager<int, string> dictionaryManager = new DictionaryManager<int, string>();
            dictionaryManager.Add(1100, "Ali");
            dictionaryManager.Add(1101, "Ahmet");
            dictionaryManager.Add(1102, "Ayşe");
            dictionaryManager.Add(1103, "Zeynep");
            dictionaryManager.Add(1104, "Tuna");

            dictionaryManager.Listele();
        }
    }
    class DictionaryManager<K,V>
    {
        K[] keys;
        V[] values;
        public DictionaryManager()
        {
            keys = new K[0];
            values = new V[0];
        }
        public void Add (K key, V value)
        {
            K[] tempKeys = keys;
            V[] tempValues = values;
            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public void Listele()
        {
            Console.WriteLine("Personel Sicil No  |  Personel Ad");
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("    " + keys[i] + "               " + values[i]);  
            }
            Console.WriteLine("\nToplam Personel Sayısı: " + (keys.Length));
        }
    }
}
