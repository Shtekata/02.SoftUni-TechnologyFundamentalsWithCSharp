using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFirst = Console.ReadLine().Split().Select(int.Parse).ToList();
            var inputSecond = Console.ReadLine().Split().Select(int.Parse).ToList();
            var output = new List<int>();
            var counter = Math.Min(inputFirst.Count, inputSecond.Count);
            for (int i = 0; i < counter; i++)
            {
                output.Add(inputFirst[0]);inputFirst.Remove(inputFirst[0]);
                output.Add(inputSecond[0]);inputSecond.Remove(inputSecond[0]);
            }
            if (inputFirst.Count > inputSecond.Count) output.AddRange(inputFirst);
            else if (inputSecond.Count > inputFirst.Count) output.AddRange(inputSecond);
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
