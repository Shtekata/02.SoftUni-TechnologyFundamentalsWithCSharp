using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new StringBuilder(Console.ReadLine().TrimStart('0'));
            var multiplier = int.Parse(Console.ReadLine());
            var temp = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                var multi = (input[i] - 48) * multiplier + temp;
                if (multi > 9 && i > 0)
                {
                    input[i] = (char)(multi % 10 + 48);
                    temp = multi / 10;
                }
                else if (multi < 10)
                {
                    input[i] = (char)(multi + 48);
                    temp = 0;
                }
                else if (multi > 9 && i == 0)
                {
                    input[0] = (char)(multi % 10 + 48);
                    input.Insert(0, (char)(multi / 10 + 48));
                }
            }
            if (multiplier == 0) Console.WriteLine(0);
            else Console.WriteLine(input);
        }
    }
}
