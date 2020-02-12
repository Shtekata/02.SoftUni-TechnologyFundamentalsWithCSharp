using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dict = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ') continue;
                else if (!dict.ContainsKey(input[i])) dict[input[i]] = 1;
                else dict[input[i]]++;
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
