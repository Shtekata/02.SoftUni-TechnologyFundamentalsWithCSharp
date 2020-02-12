using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(double.Parse);
            var counts = new SortedDictionary<double, int>();
            foreach (var item in nums)
            {
                if (counts.ContainsKey(item)) counts[item]++;
                else counts[item] = 1;
            }
            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
