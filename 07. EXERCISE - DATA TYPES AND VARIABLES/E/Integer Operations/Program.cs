﻿using System;

namespace Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());
            var fourthNumber = int.Parse(Console.ReadLine());

            var result = (firstNumber + secondNumber) / thirdNumber * fourthNumber;
            Console.WriteLine(result);

        }
    }
}
