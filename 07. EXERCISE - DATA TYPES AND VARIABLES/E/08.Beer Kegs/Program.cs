using System;

namespace _08.Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var maxModel = string.Empty;
            var maxVolume = 0.0;
            for (int i = 0; i < input; i++)
            {
                var model = Console.ReadLine();
                var radius = double.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());
                var volume = Math.PI * Math.Pow(2,radius) * height;
                if (volume > maxVolume) { maxModel = model;maxVolume = volume; };
            }
            Console.WriteLine(maxModel);
        }
    }
}
