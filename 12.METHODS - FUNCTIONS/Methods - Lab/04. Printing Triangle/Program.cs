using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintTriangle(int.Parse(Console.ReadLine()));
        }

        private static void PrintTriangle(int number)
        {
            PrintUpperHalf(number);
            PrintLowerHalf(number-1);
        }

        private static void PrintLowerHalf(int num)
        {
            for (int i = num; i >= 0; i--)
            {
                PrintLine(1, i);
            }
        }

        private static void PrintLine(int numberStart, int numberEnd)
        {
            for (int i = numberStart; i <= numberEnd; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        private static void PrintUpperHalf(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                PrintLine(1, i);
            }
        }
    }
}
