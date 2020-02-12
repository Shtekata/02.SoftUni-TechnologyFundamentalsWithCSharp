using System;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var dict = new Dictionary<string, int>();
            foreach (var item in input)
            {
                var lowItem = item.ToLower();
                if (dict.ContainsKey(lowItem)) dict[lowItem]++;
                else dict[lowItem] = 1;
            }
            foreach (var item in dict)
            {
                if (item.Value % 2 == 1) Console.Write(item.Key + " ");
            }
        }
    }
}
