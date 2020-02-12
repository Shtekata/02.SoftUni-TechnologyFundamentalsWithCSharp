using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _11._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var restricted = @"(?<firstLetter>([A-Z]*[a-z]*))(?<number>\d+)(?<secondLetter>[A-Z]*[a-z]*)";
            var output = Regex.Matches(input, restricted);
            var sum = 0.0m;
            foreach (Match item in output)
            {
                sum += SumElements(item.Groups["firstLetter"].Value, item.Groups["number"].Value, item.Groups["secondLetter"].Value);
            }
            Console.WriteLine($"{sum:f2}");
        }

        private static decimal SumElements(string a, string b, string c)
        {
            var firstLetter = char.Parse(a);
            var secondLetter = char.Parse(c);
            var number = decimal.Parse(b);
            if (firstLetter >= 'A' && firstLetter <= 'Z') number /= firstLetter - 'A' + 1;
            else if (firstLetter >= 'a' && firstLetter <= 'z') number *= firstLetter - 'a' + 1;
            if (secondLetter >= 'A' && secondLetter <= 'Z') number -= secondLetter - 'A' + 1;
            else if (secondLetter >= 'a' && secondLetter <= 'z') number += secondLetter - 'a' + 1;
            return number;
        }
    }
}
