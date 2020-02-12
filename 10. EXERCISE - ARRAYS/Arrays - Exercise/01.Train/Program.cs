using System;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            var wagons = int.Parse(Console.ReadLine());
            var wag = new int[wagons];
            var sum = 0;
            for (int i = 0; i < wagons; i++)
            {
                var input = int.Parse(Console.ReadLine());
                sum += input;
                wag[i] = input;
            }
            foreach (var item in wag)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
