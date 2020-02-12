using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _09._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var attack = new List<string>();
            var numberAttacks = 0;
            var destroyed = new List<string>();
            var numberDestroyed = 0;
            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine();
                var convert = ConvertString(input);
                var restrictions = @"(?<planet>(?<=^|@)[A-Z][a-z]+)\w*\W*(?<population>:\d+)\w*\W*(?<type>![AD]!)\w*\W*(?<soldier>->\d+)";
                var register = Regex.Match(convert, restrictions);
                if (register.Groups["type"].Value == "!A!")
                {
                    attack.Add(register.Groups["planet"].Value);
                    numberAttacks++;
                }
                else if (register.Groups["type"].Value == "!D!")
                {
                    destroyed.Add(register.Groups["planet"].Value);
                    numberDestroyed++;
                }
            }
            var orderedAttack = attack.OrderBy(x => x);
            var orderedDestroyed = destroyed.OrderBy(x => x);
            Console.WriteLine($"Attacked planets: {numberAttacks}");
            foreach (var item in orderedAttack)
            {
                Console.WriteLine($"-> {item}");
            }
            Console.WriteLine($"Destroyed planets: {numberDestroyed}");
            foreach (var item in orderedDestroyed)
            {
                Console.WriteLine($"-> {item}");
            }
        }

        private static string ConvertString(string input)
        {
            var number = 0;
            var newString = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 's' || input[i] == 'S' || input[i] == 't' || input[i] == 'T' || input[i] == 'a' || input[i] == 'A' || input[i] == 'r' || input[i] == 'R') number++;
            }
            for (int i = 0; i < input.Length; i++)
            {
                newString += (char)(input[i] - number);
            }
            return newString;
        }
    }
}
