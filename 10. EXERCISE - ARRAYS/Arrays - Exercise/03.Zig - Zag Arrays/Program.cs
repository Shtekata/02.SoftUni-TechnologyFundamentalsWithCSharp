using System;
using System.Linq;
namespace _03.Zig___Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var lineOne = new int[input];
            var lineTwo = new int[input];
            for (int i = 0; i < input; i++)
            {
                int[] current = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0) { lineOne[i] = current[0] ; lineTwo[i] = current[1]; }
                else { lineTwo[i] = current[0]; lineOne[i] = current[1]; }
            }
            foreach (var item in lineOne)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in lineTwo)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
