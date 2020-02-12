using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            var snowballs = int.Parse(Console.ReadLine());
            BigInteger highest = 0;
            var snowSnowHigh = 0;
            var snowTimeHigh = 0;
            var snowQualityHigh = 0;

            for (int i = 0; i < snowballs; i++)
            {
                var snowballSnow = int.Parse(Console.ReadLine());
                var snowballTime = int.Parse(Console.ReadLine());
                var snowballQuality = int.Parse(Console.ReadLine());
                var currenValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                if (currenValue > highest) { highest = currenValue; snowSnowHigh = snowballSnow; snowTimeHigh = snowballTime; snowQualityHigh = snowballQuality; };
            }
            Console.WriteLine($"{snowSnowHigh} : {snowTimeHigh} = {highest} ({snowQualityHigh})");
        }
    }
}
