using System;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var digits = string.Empty;
            var letters = string.Empty;
            var symbols = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i])) digits += input[i];
                else if (Char.IsLetter(input[i])) letters += input[i];
                else symbols += input[i];
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);
        }
    }
}
