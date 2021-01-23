using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
           
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "ankara");
            myDictionary.Add(2, "eskisehir");
            myDictionary.Add(3, "antalya");

            Console.WriteLine(myDictionary.Count);

            myDictionary.PrintAll();
            Console.WriteLine("----");
            myDictionary.PrintKeys();
            Console.WriteLine("----");
            myDictionary.PrintValues();
            Console.WriteLine("----");



        }
    }

    class MyDictionary<T,K> /// basic class :)) for now.... keep touch!
    {
        T[] keys;
        K[] values;

        public MyDictionary()
        {
            keys = new T[0];
            values = new K[0];
        }
        public void Add(T key,K value)
        {
            T[] tempKeys = keys;
            K[] tempValues = values;

            keys = new T[keys.Length + 1];
            values = new K[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }

        public int Count
        {
            get { return keys.Length;  }
        }
        
        public void PrintAll()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i]+ " " + values[i]);
            }
        }

        public void PrintKeys()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i]);
            }
        }

        public void PrintValues()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
        }
    }
}
