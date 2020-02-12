using System;

namespace Refractor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int current = 0;
            bool isSpecialNumber = false;
            for (int i = 1; i <= number; i++)
            {
                current = i;
                var sum = 0;
                while (current > 0)
                {
                    sum += current % 10;
                    current = current / 10;
                }
                if (sum == 5 || sum == 7 || sum == 11) isSpecialNumber = true;
                else isSpecialNumber = false;
                Console.WriteLine($"{i} -> {isSpecialNumber}");
            }

        }
    }
}
