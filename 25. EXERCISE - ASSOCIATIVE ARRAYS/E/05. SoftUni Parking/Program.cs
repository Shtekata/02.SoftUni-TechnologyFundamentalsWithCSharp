using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            var parking = new Dictionary<string, string>();
            var numbOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbOfCommands; i++)
            {
                var command = Console.ReadLine().Split();
                if (command[0] == "register")
                {
                    if (!parking.ContainsKey(command[1]))
                    {
                        parking[command[1]] = command[2];
                        Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                    }
                    else Console.WriteLine($"ERROR: already registered with plate number {parking[command[1]]}");
                }
                else
                {
                    if (parking.ContainsKey(command[1]))
                    {
                        parking.Remove(command[1]);
                        Console.WriteLine($"{command[1]} unregistered successfully");
                    }
                    else Console.WriteLine($"ERROR: user {command[1]} not found");
                }
            }
            foreach (var item in parking)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
