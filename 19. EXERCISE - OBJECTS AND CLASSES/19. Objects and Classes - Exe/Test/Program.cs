using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var L1 = new List<string>();
            var L2 = new List<string>();
            var L3 = new List<string>();
            var L = new List<List<string>>();
            L1.Add("1");
            L1.Add("1");
            L1.Add("7");
            L2.Add("2");
            L2.Add("5");
            L2.Add("3");
            L3.Add("0");
            L3.Add("2");
            L3.Add("5");
            L.Add(L1);
            L.Add(L2);
            L.Add(L3);
            L.Sort((x, y) => String.Compare(x[2], y[2]));
            foreach (var item in L)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
