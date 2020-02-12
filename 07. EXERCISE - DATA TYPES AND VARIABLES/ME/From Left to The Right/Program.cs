using System;
using System.Numerics;

namespace From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine();
                var sum = true;
                var numberOne = string.Empty;
                var numberTwo = string.Empty;
                var sumOne = 0;
                var sumTwo = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (sum) numberOne += input[j];
                    else numberTwo += input[j];
                    if (input[j] == 45) continue;
                    if (input[j] == 32) { sum = false; continue; }
                    if (sum) sumOne += input[j] - 48;
                    else sumTwo += input[j] - 48;
                }
                var numbOne = BigInteger.Parse(numberOne);
                var numbTwo = BigInteger.Parse(numberTwo);
                var maxSum = 0;
                if (numbOne >= numbTwo) maxSum = sumOne;
                else maxSum = sumTwo;
                Console.WriteLine(Math.Abs(maxSum));
            }
        }
    }
}
