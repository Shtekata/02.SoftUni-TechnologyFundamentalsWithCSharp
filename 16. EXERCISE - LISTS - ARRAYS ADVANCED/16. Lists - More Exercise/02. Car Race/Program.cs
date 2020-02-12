using System;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(x => x.ToString()).Select(int.Parse).ToList();
            var leftSide = 0.0;
            var rightSide = 0.0;

            for (int i = 0; i < input.Count/2; i++)
            {
                if (input[i] == 0) leftSide *= 0.8;
                leftSide += input[i];
            }
            for (int i = input.Count-1; i > input.Count/2; i--)
            {
                if (input[i] == 0) rightSide *= 0.8;
                rightSide += input[i];
            }
            var winner = "";
            var bestTime = 0.0;
            if (leftSide < rightSide) { winner = "left"; bestTime = leftSide; }
            else { winner = "right"; bestTime = rightSide; }
            Console.WriteLine($"The winner is {winner} with total time: {bestTime}");
        }
    }
}
