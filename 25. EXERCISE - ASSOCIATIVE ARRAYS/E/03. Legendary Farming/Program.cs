using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyMaterials = new Dictionary<string, int>();
            var junkMaterials = new Dictionary<string, int>();
            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["motes"] = 0;
            ColectMaterials(keyMaterials, junkMaterials);
            Console.WriteLine($"{ObtainLegendary(keyMaterials)} obtained!");
            var firstThree = keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            Print(firstThree);
            var junk = junkMaterials.OrderBy(x => x.Key);
            Print(junk);
        }

        private static string ObtainLegendary(Dictionary<string, int> keyMaterials)
        {
            var material = keyMaterials.Where(x => x.Value >= 250).First().Key;
            keyMaterials[material] -= 250;
            switch (material)
            {
                case "shards": return "Shadowmourne";
                case "fragments": return "Valanyr";
                case "motes":return "Dragonwrath";
                default: return "A";
            }
        }

        private static void ColectMaterials(Dictionary<string, int> keyMaterials, Dictionary<string, int> junkMaterials)
        {
            while (true)
            {
                var input = Console.ReadLine().Split();
                for (int i = 0; i < input.Length; i += 2)
                {
                    var item = input[i + 1].ToLower();
                    var quantity = int.Parse(input[i]);
                    if (keyMaterials.ContainsKey(item))
                    {
                        keyMaterials[item] += quantity;

                        if (keyMaterials[item] >= 250)
                        {
                            return;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(item)) junkMaterials.Add(item, 0);
                        junkMaterials[item] += quantity;
                    }
                }
            }
        }

        private static void Print(IOrderedEnumerable<KeyValuePair<string, int>> input)
        {
            foreach (var item in input)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
