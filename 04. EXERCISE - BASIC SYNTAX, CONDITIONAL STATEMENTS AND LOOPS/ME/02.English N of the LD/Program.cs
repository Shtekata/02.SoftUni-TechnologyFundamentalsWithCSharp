using System;
using System.Numerics;

namespace _02.English_N_of_the_LD
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Math.Abs(int.Parse(Console.ReadLine()));
            if (input >= 0)
            {
                if (input > 9) input = input % 10;
                switch (input)
                {
                    case 0: Console.WriteLine($"zero"); break;
                    case 1: Console.WriteLine($"one"); break;
                    case 2: Console.WriteLine($"two"); break;
                    case 3: Console.WriteLine($"three"); break;
                    case 4: Console.WriteLine($"four"); break;
                    case 5: Console.WriteLine($"five"); break;
                    case 6: Console.WriteLine($"six"); break;
                    case 7: Console.WriteLine($"seven"); break;
                    case 8: Console.WriteLine($"eight"); break;
                    case 9: Console.WriteLine($"nine"); break;
                }
            
            }
        }
    }
}
