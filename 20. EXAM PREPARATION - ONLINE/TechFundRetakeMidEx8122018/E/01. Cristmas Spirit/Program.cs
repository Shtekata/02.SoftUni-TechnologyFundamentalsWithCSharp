using System;

namespace _01._Cristmas_Spirit
{
    class Program
    {
        static void Main(string[] args)
        {
            var quantity = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var spirit = 0;
            var costs = 0;
            for (int i = 1; i <= days; i++)
            {
                if (i % 11 == 0) quantity += 2;
                if (i % 2 == 0) { costs += 2 * quantity; spirit += 5; }
                if (i % 3 == 0) { costs += 8 * quantity; spirit += 13; }
                if (i % 5 == 0)
                {
                    costs += 15 * quantity;
                    spirit += 17;
                    if (i % 3 == 0) spirit += 30;
                }
                if (i % 10 == 0) { costs += 23; spirit -= 20; }
            }
            if (days % 10 == 0) spirit -= 30;
            Console.WriteLine($"Total cost: {costs}");
            Console.WriteLine($"Total spirit: {spirit}");
        }
    }
}
