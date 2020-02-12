using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var stringOne = input[0];
            var stringTwo = input[1];

            var sum = Sum(stringOne, stringTwo);
            Console.WriteLine(sum);
        }

        private static int Sum(string stringOne, string stringTwo)
        {
            var length = Math.Max(stringOne.Length, stringTwo.Length);
            var sum = 0;
            for (int i = 0; i < length; i++)
            {
                var coefficientTwo = 1;
                var coefficientOne = 1;
                if (i < stringOne.Length) coefficientOne = stringOne[i];
                if (i < stringTwo.Length) coefficientTwo = stringTwo[i];
                sum += coefficientOne * coefficientTwo;
            }
            return sum;
        }
    }
}
