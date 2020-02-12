using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var sum = 0;
            var removeElement = 0;
            while (input.Count > 0)
            {
                var index = int.Parse(Console.ReadLine());
                if (index < 0 && input.Count > 1) { removeElement = input[0]; input[0] = input[input.Count - 1]; sum += removeElement; index = 0; Resize(input, removeElement); }
                else if (index > input.Count - 1 && input.Count > 1) { removeElement = input[input.Count - 1]; input[input.Count - 1] = input[0]; sum += removeElement; index = 0; Resize(input, removeElement); }
                else if (index >= 0 && index < input.Count) { removeElement = input[index]; sum += input[index]; Resize(input, removeElement); input.RemoveAt(index); }
            }
            Console.WriteLine(sum);
        }

        private static void Resize(List<int> input, int index)
        {
            var ind = index;
            for (int i = 0; i < input.Count; i++)
            {
                    if (ind >= input[i]) input[i] += ind;
                    else input[i] -= ind;
            }
        }
    }
}
