using System;
using System.Text;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var repeat = int.Parse(Console.ReadLine());
            var newString = NewString(input, repeat);
            Console.WriteLine(newString);
        }

        private static object NewString(string input, int repeat)
        {
            var wholeString = new StringBuilder();
            for (int i = 0; i < repeat; i++)
            {
                wholeString.Append(input);
            }
            return wholeString.ToString();
        }
    }
}
