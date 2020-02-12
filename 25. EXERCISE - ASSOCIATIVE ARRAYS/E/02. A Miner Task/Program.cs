using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, int>();
            var input = Console.ReadLine();
            while (input != "stop")
            {
                var quantity = int.Parse(Console.ReadLine());
                if (!resources.ContainsKey(input)) resources.Add(input, 0);
                resources[input] += quantity;
                input = Console.ReadLine();
            }
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
