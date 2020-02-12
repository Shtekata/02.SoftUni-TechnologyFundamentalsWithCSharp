using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOne = int.Parse(Console.ReadLine());
            var numberTwo = int.Parse(Console.ReadLine());
            while (numberOne < 0 || numberTwo < 0)
            {
                numberOne = int.Parse(Console.ReadLine());
                numberTwo = int.Parse(Console.ReadLine());

            }
            var factOne = Factorial(numberOne);
            var factTwo = Factorial(numberTwo);
            double result = factOne / factTwo;
            Console.WriteLine($"{result:f2}");
        }

        private static double Factorial(int number)
        {
            var factorial = 1.00;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
