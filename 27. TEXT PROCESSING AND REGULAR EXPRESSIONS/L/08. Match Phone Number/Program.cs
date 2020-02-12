using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _08._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var restrictions = @"(?<!\d)[+]359([ -])2\1\d{3}\1\d{4}\b";
            var output = Regex.Matches(input, restrictions);
            var list = new List<string>();
            foreach (Match item in output)
            {
                list.Add(item.Value);
            }
            Console.WriteLine(string.Join(", ",list));
        }
    }
}
