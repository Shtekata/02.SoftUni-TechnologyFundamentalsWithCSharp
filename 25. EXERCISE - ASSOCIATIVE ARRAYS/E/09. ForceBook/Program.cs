using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var side = new Dictionary<string, List<string>>();
            while (input != "Lumpawaroo")
            {
                var sideOne = true;
                var inputNext = new List<string>();
                if (input.Contains(" | ")) inputNext = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToList();
                else { inputNext = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToList(); sideOne = false; }
                if (sideOne)
                {
                    if (!side.ContainsKey(inputNext[0])) side.Add(inputNext[0], new List<string>());
                    if (!side.Values.Any(x => x.Contains(inputNext[1]))) side[inputNext[0]].Add(inputNext[1]);
                }
                else
                {
                    foreach (var item in side)
                    {
                        if (item.Value.Contains(inputNext[0])) item.Value.Remove(inputNext[0]);
                    }
                    if (!side.ContainsKey(inputNext[1])) side.Add(inputNext[1], new List<string>());
                    side[inputNext[1]].Add(inputNext[0]);
                    Console.WriteLine($"{inputNext[0]} joins the {inputNext[1]} side!");
                }
                input = Console.ReadLine();
            }
            foreach (var item in side.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).Where(x => x.Value.Count > 0))
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                foreach (var user in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
