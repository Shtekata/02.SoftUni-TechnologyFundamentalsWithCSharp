using System;
using System.Text.RegularExpressions;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ");
            foreach (var item in input)
            {
                var print = true;
                if (item.Length > 2 && item.Length < 17)
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        if (!Char.IsDigit(item[i]) && !Char.IsLetter(item[i]) && item[i] != '-' && item[i] != '_')
                        {
                            print = false; break;
                        }
                    }
                    if (print) Console.WriteLine(item);
                }
            }
        }
    }
}
