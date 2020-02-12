using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<string>>();
            for (int i = 0; i < number; i++)
            {
                var word = Console.ReadLine();
                var synonym = Console.ReadLine();
                if (!dict.ContainsKey(word)) dict[word] = new List<string>();
                dict[word].Add(synonym);
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
