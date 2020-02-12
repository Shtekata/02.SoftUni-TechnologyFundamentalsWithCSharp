using System;

namespace _02.Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var numbers = new int[input];
            for (int i = 0; i < numbers.Length; i++)
            {
                var numb = int.Parse(Console.ReadLine());
                numbers[i] = numb;
            }
            for (int j = numbers.Length-1; j >= 0; j--)
            {
                Console.Write($"{numbers[j]} ");
            }
        }
    }
}
