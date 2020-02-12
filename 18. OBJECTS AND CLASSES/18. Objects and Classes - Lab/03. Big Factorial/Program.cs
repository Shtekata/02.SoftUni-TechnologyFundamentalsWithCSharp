using System;
using System.Numerics;

namespace _03._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            BigInteger fact = 1;
            for (int i = 2; i <= input; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }
    }
}
