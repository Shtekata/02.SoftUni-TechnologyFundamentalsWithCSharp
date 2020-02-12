using System;
using System.Linq;
namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var length = input.Length - 1;
            for (int i = 0; i < input.Length-1; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    input[j] += input[j + 1];
                }
                length--;
            }
            Console.WriteLine(input[0]);
        }
    }
}
