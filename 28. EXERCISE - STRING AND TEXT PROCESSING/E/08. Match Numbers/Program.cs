using System;
using System.Text.RegularExpressions;

namespace _08._Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string restriction = @"(?<=^|\s)-?\d+(\.\d+)?(?=$|\s)";
            MatchCollection output = Regex.Matches(input, restriction);
            foreach (var item in output)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
