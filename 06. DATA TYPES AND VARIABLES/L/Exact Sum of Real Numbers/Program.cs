using System;
using System.Numerics;

namespace Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numb = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < numb; i++)
            {
                decimal input = decimal.Parse(Console.ReadLine());                
                sum += input;
            }
            Console.WriteLine(sum);
        }
    }
}
