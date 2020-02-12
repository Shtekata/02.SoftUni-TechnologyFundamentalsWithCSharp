using System;
using System.Linq;

namespace Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            for (int i = 0; i < input.Length/2; i++)
            {
                var oldI = input[i];
                input[i] = input[input.Length - i - 1];
                input[input.Length - i - 1] = oldI;
            }
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
