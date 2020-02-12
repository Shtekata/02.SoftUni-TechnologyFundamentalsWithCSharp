using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            var train = Console.ReadLine().Split().Select(int.Parse).ToList();
            var maxCapacity = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            while (input != "end")
            {
                var newInput = input.Split().ToList();
                if (newInput.Count == 2) train.Add(int.Parse(newInput[1]));
                else for (int i = 0; i < train.Count; i++)
                    {
                        if (train[i] + int.Parse(newInput[0]) <= maxCapacity) { train[i] += int.Parse(newInput[0]); break; }
                    }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",train));
        }
    }
}
