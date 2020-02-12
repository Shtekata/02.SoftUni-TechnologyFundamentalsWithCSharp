using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add": Add(a, b); break;
                case "multiply": Multiply(a, b); break;
                case "subtract": Subtrct(a, b); break;
                case "divide": Divide(a, b); break;
            }
        }

        private static void Divide(int a, int b)
        {
            Console.WriteLine(a/b);
        }

        private static void Subtrct(int a, int b)
        {
            Console.WriteLine(a-b);
        }

        private static void Multiply(int a, int b)
        {
            Console.WriteLine(a*b);
        }

        private static void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
    }
}
