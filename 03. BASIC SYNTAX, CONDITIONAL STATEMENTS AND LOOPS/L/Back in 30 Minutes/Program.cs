using System;

namespace Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minute = int.Parse(Console.ReadLine());

            minute += 30;
            if (minute >= 60) { minute -= 60; hours += 1; }
            if (hours >= 24) hours -= 24;
            Console.WriteLine($"{hours}:{minute:d2}");
        }
    }
}
