using System;
using System.Linq;
namespace _07.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var maxNumber = 1;
            var number = 1;
            var maxSequence = 0;
            var sequence = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1]) { number++; sequence = input[i]; }
                else {number = 1; sequence = 0; }
                if (number > maxNumber) { maxNumber = number; maxSequence = sequence; }

            }
            for (int i = 0; i < maxNumber; i++)
            {
                Console.Write(maxSequence + " ");
            }
            Console.WriteLine();
        }
    }
}
