using System;
using System.Linq;
namespace _04.Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rotation = int.Parse(Console.ReadLine());
            if (rotation > input.Length) rotation %= input.Length;
            var output = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                var ii = i + rotation;
                if (ii > input.Length-1) ii -= input.Length;
                output[i] = input[ii];
            }
            foreach (var item in output)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
