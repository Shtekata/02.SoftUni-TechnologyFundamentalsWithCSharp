using System;
using System.Text.RegularExpressions;

namespace _07._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var restrictions = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            var output = Regex.Matches(input, restrictions);
            foreach (Match item in output)
            {
                Console.WriteLine($"Day: {item.Groups["day"].Value}, Month: {item.Groups["month"].Value}," +
                    $" Year: {item.Groups["year"].Value}");
            }
        }
    }
}
