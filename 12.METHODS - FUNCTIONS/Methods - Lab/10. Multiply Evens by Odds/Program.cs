using System;
using System.Linq;
namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Math.Abs(int.Parse(Console.ReadLine()));
            var multiple = GetMultipleOfEvenAndOdds(input);
            Console.WriteLine(multiple);
        }

        private static object GetMultipleOfEvenAndOdds(int input)
        {
            var even = GetSumOfEvenDigits(input);
            var odd = GetSumOfOddDigits(input);
            return even * odd;
        }

        private static int GetSumOfOddDigits(int input)
        {
            var odd = input.ToString().ToArray();
            var sumOdd = 0;
            for (int i = 0; i < odd.Length; i++)
            {
                if (odd[i] % 2 == 1) sumOdd += odd[i] - 48;
            }
            return sumOdd;
        }

        private static int GetSumOfEvenDigits(int input)
        {
            var even = input.ToString().ToArray();
            var sumEven = 0;
            for (int i = 0; i < even.Length; i++)
            {
                if (even[i] % 2 == 0) sumEven += even[i] - 48;
            }
            return sumEven;
        }
    }
}
