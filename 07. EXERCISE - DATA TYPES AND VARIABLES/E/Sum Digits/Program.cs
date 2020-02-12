using System;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var sum = 0;
            while (input>0)
            {
                sum += input % 10;
                input /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
