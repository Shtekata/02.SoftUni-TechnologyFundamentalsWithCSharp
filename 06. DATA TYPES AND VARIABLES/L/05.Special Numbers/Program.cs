using System;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var special = true;
            for (int i = 1; i <= n; i++)
            {
                var current = i;
                var sum = 0;
                while (current != 0)
                {
                    sum += current % 10;
                    current = current / 10;
                }
                if (sum == 5 || sum == 7 || sum == 11) special = true;
                else special = false;
                Console.WriteLine($"{i} -> {special}");
            }
        }
    }
}
