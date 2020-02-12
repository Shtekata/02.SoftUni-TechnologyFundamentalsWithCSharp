using System;

namespace Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var startNumber = int.Parse(Console.ReadLine());
            var endNumber = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = startNumber; i <= endNumber; i++)
            {
                sum += i;
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
