using System;

namespace Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            var pounds = decimal.Parse(Console.ReadLine());
            var dollars = pounds * 1.31m;
            Console.WriteLine($"{dollars:f3}");
        }
    }
}
