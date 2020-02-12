using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|').ToList();
            var temp = "";
            for (int i = 0; i < input.Count / 2; i++)
            {
                temp = input[i];
                input[i] = input[input.Count - 1 - i];
                input[input.Count - 1 - i] = temp;
            }
            var stringNew = "";
            for (int i = 0; i < input.Count; i++)
            {
                stringNew += ' ' + input[i];
            }
            var output = stringNew.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
