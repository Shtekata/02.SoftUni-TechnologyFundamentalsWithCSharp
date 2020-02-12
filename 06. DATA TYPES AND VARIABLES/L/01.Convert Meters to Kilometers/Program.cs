using System;

namespace _01.Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var meters = int.Parse(Console.ReadLine());
            var km = meters / 1000.0;
            Console.WriteLine($"{km:f2}");
        }
    }
}
