using System;
using System.Linq;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var numbers = new int[input.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (int)Math.Round(input[i],MidpointRounding.AwayFromZero);
                Console.WriteLine($"{input[i]} => {numbers[i]} ");
            }
            Console.WriteLine();
        }
    }
}
