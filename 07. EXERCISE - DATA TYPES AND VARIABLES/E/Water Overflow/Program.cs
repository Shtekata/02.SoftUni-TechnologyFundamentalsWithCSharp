using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var liters = 0;
            for (int i = 0; i < input; i++)
            {
                var pour = int.Parse(Console.ReadLine());
                if ((pour + liters) <= 255) liters += pour;
                else Console.WriteLine($"Insufficient capacity!");
            }
            Console.WriteLine(liters);
        }
    }
}
