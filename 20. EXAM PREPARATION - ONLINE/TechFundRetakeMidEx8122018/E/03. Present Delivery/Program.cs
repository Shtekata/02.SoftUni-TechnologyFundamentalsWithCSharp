using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('@').Select(int.Parse).ToArray();
            var command = Console.ReadLine();
            var currentIndex = 0;
            var count = 0;
            var ifExist = new List<int>();
            while (command != "Merry Xmas!")
            {
                var str = command.Split();
                var jump = int.Parse(str[1]);
                if (str[0].ToLower() == "jump" && jump > 0)
                {
                    currentIndex += jump;
                    if (currentIndex >= input.Length) currentIndex %= input.Length;
                    if (input[currentIndex] == 0 && !ifExist.Contains(currentIndex))
                    {
                        Console.WriteLine($"House {currentIndex} will have a Merry Christmas.");
                        ifExist.Add(currentIndex);
                    }
                    if (input[currentIndex] > 1)
                    {
                        input[currentIndex] -= 2;
                        if (input[currentIndex] == 0 && !ifExist.Contains(currentIndex)) count++;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Santa's last position was {currentIndex}.");
            if (count == input.Length) Console.WriteLine($"Mission was successful.");
            else Console.WriteLine($"Santa has failed {input.Length - count} houses.");
        }
    }
}
