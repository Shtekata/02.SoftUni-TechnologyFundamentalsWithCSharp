using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var command = Console.ReadLine().Split().ToList();
            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Add": input.Add(int.Parse(command[1])); break;
                    case "Insert":
                        if (int.Parse(command[2]) >= 0 && int.Parse(command[2]) < input.Count)
                            input.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        else Console.WriteLine("Invalid index"); break;
                    case "Remove":
                        if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < input.Count)
                            input.RemoveAt(int.Parse(command[1]));
                        else Console.WriteLine("Invalid index"); break;
                    case "Shift": Shift(input, command[1], command[2]); break;

                }
                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ", input));
        }

        private static void Shift(List<int> input, string v1, string v2)
        {
            var output = new List<int>();
            var number = int.Parse(v2);
            if (number > input.Count) number %= input.Count;
            for (int i = 0; i < input.Count; i++)
            {
                if (v1 == "left") if (i + number >= input.Count) output.Add(input[i + number - input.Count]); else output.Add(input[i + number]);
                if (v1 == "right") if (input.Count - number + i >= input.Count) output.Add(input[i - number]); else output.Add(input[input.Count - number + i]);
            }
            for (int i = 0; i < output.Count; i++)
            {
                input[i] = output[i];
            }
        }
    }
}
