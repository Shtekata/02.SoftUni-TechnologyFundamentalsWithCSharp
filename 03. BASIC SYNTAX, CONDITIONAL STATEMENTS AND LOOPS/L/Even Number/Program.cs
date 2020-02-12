using System;

namespace Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 1;
            while (true)
            {
                try
                {
                    n = Math.Abs(int.Parse(Console.ReadLine()));
                    if (n % 2 == 1) Console.WriteLine("Please write an even number.");
                    else break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please write an even number.");
                }
            }
            Console.WriteLine($"The number is: {n}");
        }
    }
}
