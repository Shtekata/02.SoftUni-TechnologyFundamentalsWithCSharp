using System;
using System.Linq;
namespace Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputFirst = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputSecond = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var length = Math.Max(inputFirst.Length, inputSecond.Length);
            var index = 0;
            var sum = 0;
            var identical = true;
            for (int i = 0; i < length; i++)
            {
                if (inputFirst[i] != inputSecond[i]) { identical = false; index = i; break; }
                else sum += inputFirst[i];
            }
            if (identical) Console.WriteLine($"Arrays are identical. Sum: {sum}");
            else Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
        }
    }
}
