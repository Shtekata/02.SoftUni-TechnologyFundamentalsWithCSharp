using System;
using System.Linq;
namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = int.Parse(Console.ReadLine());

            var longestSubsequence = -1;
            var longestSubIndex = -1;
            var longestSubSum = -1;
            var indexOfLongest = 0;
            var secuence = new int[lenght];

            var input = Console.ReadLine();

            var indexOfSecuence = 1;

            while (input != "Clone them!")
            {
                int[] currentSequence = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var subsicuence = 0;
                var subIndex = -1;
                var subSum = 0;

                var count = 0;


                for (int i = 0; i < currentSequence.Length; i++)
                {
                    if (currentSequence[i] == 1) { subSum++; count++; }
                    else count = 0;

                    if (count > subsicuence) { subsicuence = count; subIndex = i - count + 1; }
                }
                if (subsicuence > longestSubsequence) { longestSubsequence = subsicuence; secuence = currentSequence; longestSubIndex = subIndex; longestSubSum = subSum; indexOfLongest = indexOfSecuence; }

                else if (subsicuence == longestSubsequence && subIndex < longestSubIndex) { longestSubIndex = subIndex; secuence = currentSequence; longestSubSum = subSum; indexOfLongest = indexOfSecuence; }

                else if (subsicuence == longestSubsequence && subIndex == longestSubIndex && subSum > longestSubSum) { longestSubSum = subSum; secuence = currentSequence; indexOfLongest = indexOfSecuence; }
                input = Console.ReadLine();
                indexOfSecuence++;

            }
            Console.WriteLine($"Best DNA sample {indexOfLongest} with sum: {longestSubSum}.");
            Console.WriteLine(string.Join(' ',secuence));
        }
    }
}
