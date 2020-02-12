using System;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputSorted = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).ToArray();
            var count = inputSorted.Count();
            if (count > 3) count = 3;
            for (int i = 0; i < count; i++)
            {
                Console.Write(inputSorted[i] + " ");
            }
        }
    }
}
