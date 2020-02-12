using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _10._Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToUpper();
            var selection = @"(?<string>([^\d])+)(?<repeat>\d+)";
            var selectedInput = Regex.Matches(input, selection);
            var output = new StringBuilder();
            var unique = new Dictionary<char, int>();
            foreach (Match item in selectedInput)
            {
                var text = item.Groups["string"].Value;
                var count = int.Parse(item.Groups["repeat"].Value);
                if (count == 0) continue;
                for (int i = 0; i < text.Length; i++)
                {
                    if (!unique.ContainsKey(text[i])) unique[text[i]] = 1;
                }
                for (int j = 0; j < count; j++)
                {
                    output.Append(text);
                }
            }
            Console.WriteLine($"Unique symbols used: {unique.Count}");
            Console.WriteLine(output);
        }
    }
}
