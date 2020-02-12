using System;
using System.Linq;
namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var bigger = true;
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[j] >= input[i]) bigger = false;
                }
                if (bigger) output += input[i] + " ";
                bigger = true;
            }
            var outArr = new string[] { output };
            foreach (var item in outArr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
