using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Cooking_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var bestTotalQuality = -101;
            var bestAverageQuality = -101.0;
            var fewestLength = -101;
            var bestBatch = new List<int>();

            while (input!="Bake It!")
            {
                var currentBatch = input.Split('#').Select(int.Parse).ToList();
                var currentTotalQuality = 0;
                for (int i = 0; i < currentBatch.Count; i++)
                {
                    currentTotalQuality += currentBatch[i];
                }
                var currentAverageQuality = currentTotalQuality / (double)currentBatch.Count;

                if (currentTotalQuality > bestTotalQuality)
                {
                    bestTotalQuality = currentTotalQuality;
                    bestAverageQuality = currentAverageQuality;
                    fewestLength = currentBatch.Count;
                    bestBatch = currentBatch;
                }
                else if (currentTotalQuality == bestTotalQuality && currentAverageQuality > bestAverageQuality)
                {
                    bestTotalQuality = currentTotalQuality;
                    bestAverageQuality = currentAverageQuality;
                    fewestLength = currentBatch.Count;
                    bestBatch = currentBatch;

                }
                else if(currentTotalQuality==bestTotalQuality&&currentAverageQuality==bestAverageQuality
                    && currentBatch.Count < fewestLength)
                {
                    bestTotalQuality = currentTotalQuality;
                    bestAverageQuality = currentAverageQuality;
                    fewestLength = currentBatch.Count;
                    bestBatch = currentBatch;

                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best Batch quality: {bestTotalQuality}");
            Console.WriteLine(string.Join(' ',bestBatch));
        }
    }
}
