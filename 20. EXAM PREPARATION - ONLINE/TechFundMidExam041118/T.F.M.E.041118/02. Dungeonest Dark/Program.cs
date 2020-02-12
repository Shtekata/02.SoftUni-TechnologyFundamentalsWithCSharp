using System;

namespace _02._Dungeonest_Dark
{
    class Program
    {
        static void Main(string[] args)
        {
            var rooms = Console.ReadLine().Split('|');
            var healt = 100;
            var coins = 0;
            var currentHealth = 100;
            for (int i = 0; i < rooms.Length; i++)
            {
                var contains = rooms[i].Split();
                var value = int.Parse(contains[1]);
                if (contains[0] == "potion")
                {
                    currentHealth += value;
                    if (currentHealth > 100) { value = 100 - currentHealth + value; currentHealth = 100; }
                    Console.WriteLine($"You healed for {value} hp.");
                    Console.WriteLine($"Current health: {currentHealth} hp.");

                }
                else if (contains[0] == "chest")
                {
                    coins += value;
                    Console.WriteLine($"You found {value} coins.");
                }
                else
                {
                    currentHealth -= value;
                    if (currentHealth > 0) Console.WriteLine($"You slayed {contains[0]}.");
                    else
                    {
                        Console.WriteLine($"You died! Killed by {contains[0]}.");
                        Console.WriteLine($"Best room: {i+1}");
                        return;
                    }
                }
            }
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Health: {currentHealth}");
        }
    }
}
