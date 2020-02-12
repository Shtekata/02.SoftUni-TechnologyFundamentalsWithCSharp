using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var divisible = false;
            var div = 0;
            if (number % 10 == 0) { divisible = true; div = 10; }
            else if (number % 7 == 0) { divisible = true; div = 7; }
            else if (number % 6 == 0) { divisible = true; div = 6; }
            else if (number % 3 == 0) { divisible = true; div = 3; }
            else if (number % 2 == 0) { divisible = true; div = 2; }
            if (!divisible) Console.WriteLine($"Not divisible");
            else Console.WriteLine($"The number is divisible by {div}");
        }
    }
}
