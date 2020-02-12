﻿using System;
using System.Linq;

namespace Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
