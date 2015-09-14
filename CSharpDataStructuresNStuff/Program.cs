using System;
using System.Collections.Generic;

namespace DictionaryFirstUse
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "one");
            dictionary.Add(2, "two");
            dictionary.Add(3, "three");
            dictionary.Add(4, "four");
            dictionary.Add(5, "five");
            dictionary.Add(6, "six");
            dictionary.Add(7, "seven");
            dictionary.Add(8, "eight");
            dictionary.Add(9, "nine");

            List<int> keys = new List<int>(dictionary.Keys);

            //foreach (int i in keys)
            //{
            //    Console.WriteLine(dictionary[i]);
            //}

            Console.WriteLine(dictionary[4]);

            Console.ReadLine();

        }
    }
}
