using System;
using System.Linq;
namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputFirst = Console.ReadLine().Split().ToArray();
            string[] inputSecond = Console.ReadLine().Split().ToArray();
            for (int i = 0; i < inputSecond.Length; i++)
            {
                for (int j = 0; j < inputFirst.Length; j++)
                {
                    if (inputSecond[i] == inputFirst[j]) Console.Write($"{inputSecond[i]} ");
                }
            }
            Console.WriteLine();
        }
    }
}
