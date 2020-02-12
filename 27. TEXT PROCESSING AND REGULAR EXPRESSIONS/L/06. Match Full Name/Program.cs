using System;
using System.Text.RegularExpressions;

namespace _06._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string restrictions = @"\b[A-Z][a-z]+[\s{1}][A-Z][a-z]+\b";
            var output = Regex.Matches(input, restrictions);
            foreach (var item in output)
            {
                Console.Write(item + " ");
            }
        }
    }
}
