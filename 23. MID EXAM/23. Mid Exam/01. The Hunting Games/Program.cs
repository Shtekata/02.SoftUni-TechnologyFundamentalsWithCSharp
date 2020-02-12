using System;

namespace _01._The_Hunting_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var players = int.Parse(Console.ReadLine());
            var groupEnergy = double.Parse(Console.ReadLine());
            var waterPerPerson = double.Parse(Console.ReadLine());
            var foodPerPerson = double.Parse(Console.ReadLine());
            var water = players * waterPerPerson * days;
            var food = players * foodPerPerson * days;

            for (int i = 1; i <= days; i++)
            {
                var energyLoss = double.Parse(Console.ReadLine());
                groupEnergy -= energyLoss;
                if (groupEnergy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {food:f2} food and {water:f2} water.");
                    return;
                }
                if (i % 2 == 0)
                {
                    groupEnergy *= 1.05;
                    water *= 0.7;
                }
                if (i % 3 == 0)
                {
                    groupEnergy *= 1.10;
                    food -= food / players;
                }
            }
            Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
        }
    }
}
