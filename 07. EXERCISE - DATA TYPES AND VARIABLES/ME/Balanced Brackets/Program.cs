using System;

namespace Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var next = false;
            var leftB = true;
            var brackets = true;
            var counterL = 0;
            var counterR = 0;

            for (int i = 0; i < number; i++)
            {
                var line = Console.ReadLine();
                if (line == "(" && leftB && next == true) brackets = false;
                if (line == ")" && !leftB && next == true) brackets = false;
                if (line == "(") { leftB = true; next = true; counterL++; }
                if (line == ")") { leftB = false; next = true; counterR++; }
                if (counterL == 0 && counterR == 1) brackets = false;
            }
            if (counterL != counterR) brackets = false;
            if (brackets) Console.WriteLine($"BALANCED");
            else Console.WriteLine($"UNBALANCED");
        }
    }
}
