using System;
using System.Linq;
namespace _06.Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var sumOne = 0;
            var sumTwo = 0;
            var isNum = false;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    sumOne += input[j];
                }
                for (int k = i + 1; k < input.Length; k++)
                {
                    sumTwo += input[k];
                }
                if (sumOne == sumTwo)
                { isNum = true; Console.WriteLine(i); }
                sumOne = 0;
                sumTwo = 0;
            }
            if(!isNum) Console.WriteLine("no");
        }
    }
}
