using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._On_the_Way_to_Annapur
{
    class Program
    {
        static void Main(string[] args)
        {
            var diary = new Dictionary<string, List<string>>();
            var input = Console.ReadLine();
            while (input != "END")
            {
                var input1 = input.Split("->");
                if (input1[0] == "Add")
                {
                    if (!diary.ContainsKey(input1[1]))
                    {
                        var listOfItems = new List<string>();
                        diary.Add(input1[1], listOfItems);

                    }
                    if (input1[2].Contains(','))
                    {
                        var items = input1[2].Split(",");
                        for (int i = 0; i < items.Length; i++)
                        {
                            diary[input1[1]].Add(items[i]);
                        }
                    }
                    else diary[input1[1]].Add(input1[2]);
                    
                }
                if (input1[0] == "Remove")
                {
                    if (diary.ContainsKey(input1[1]))
                    {
                        diary.Remove(input1[1]);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Stores list:");
            foreach (var item in diary.OrderByDescending(x=>x.Value.Count).ThenByDescending(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var elem in item.Value)
                {
                    Console.WriteLine($"<<{elem}>>");
                }
            }
        }
    }
}
