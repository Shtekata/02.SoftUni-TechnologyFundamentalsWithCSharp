using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var middle = MiddleCharactersMethod(input);
            Console.WriteLine(middle);
        }

        private static object MiddleCharactersMethod(string input)
        {
            var middle = "";
            var odd = false;
            if (input.Length % 2 == 1) odd = true;
            if (odd) middle += input[input.Length / 2];
            else
            {
                middle += input[input.Length / 2 - 1];
                middle += input[input.Length / 2];
            }
            return middle;
        }
    }
}
