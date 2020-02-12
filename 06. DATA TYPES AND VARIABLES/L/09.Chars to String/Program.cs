using System;

namespace _09.Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = char.Parse(Console.ReadLine());
            var b = char.Parse(Console.ReadLine());
            var c = char.Parse(Console.ReadLine());
            string d = $"{a}{b}{c}";
            Console.WriteLine(d);
        }
    }
}
