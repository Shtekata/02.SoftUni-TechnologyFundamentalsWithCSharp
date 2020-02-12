using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            var yield = int.Parse(Console.ReadLine());
            var days = 0;
            var spice = 0;
            while (yield >= 100)
            {
                spice += yield - 26;
                yield -= 10;
                days++;
            }
            if (days!=0)spice -= 26;
            Console.WriteLine(days);
            Console.WriteLine(spice);
        }
    }
}
