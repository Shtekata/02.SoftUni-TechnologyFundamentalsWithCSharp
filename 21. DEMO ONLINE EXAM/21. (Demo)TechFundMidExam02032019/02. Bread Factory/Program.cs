using System;

namespace _02._Bread_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = Console.ReadLine().Split('|');
            var energy = 100;
            var coins = 100;

            for (int i = 0; i < day.Length; i++)
            {
                var command = day[i].Split('-');
                var number = int.Parse(command[1]);
                if (command[0] == "rest")
                {
                    var oldEnergy = energy;
                    energy += number;
                    if (energy > 100) energy = 100;
                    Console.WriteLine($"You gained {energy - oldEnergy} energy.");
                    Console.WriteLine($"Current energy: {energy}.");
                }
                else if (command[0] == "order")
                {
                    if (energy >= 30)
                    {
                        coins += number;
                        energy -= 30;
                        Console.WriteLine($"You earned {number} coins.");
                    }
                    else
                    {
                        energy += 50;
                        Console.WriteLine($"You had to rest!");
                    }
                }
                else
                {
                    if (coins > number)
                    {
                        coins -= number;
                        Console.WriteLine($"You bought {command[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {command[0]}.");
                        return;
                    }
                }
            }
            Console.WriteLine($"Day completed!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Energy: {energy}");
        }
    }
}
