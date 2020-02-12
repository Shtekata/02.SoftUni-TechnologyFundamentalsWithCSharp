using System;

namespace _10.Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = char.Parse(Console.ReadLine());
            if (input > 64 && input < 91) Console.WriteLine($"upper-case");
            else Console.WriteLine($"lower-case");
        }
    }
}
