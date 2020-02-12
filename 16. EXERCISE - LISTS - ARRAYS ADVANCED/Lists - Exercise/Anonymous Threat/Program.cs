using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();
            var command = Console.ReadLine().Split().ToList();
            while (command[0] != "3:1")
            {
                if (command[0] == "merge") Merge(input, command[1], command[2]);
                if (command[0] == "divide") Divide(input, command[1], command[2]);
                command = Console.ReadLine().Split().ToList();

            }
            Console.WriteLine(string.Join(' ', input));
        }

        private static void Merge(List<string> input, string v1, string v2)
        {
            var startIndex = int.Parse(v1);
            var endIndex = int.Parse(v2);
            if (startIndex < 0) startIndex = 0;
            if (endIndex < 0) endIndex = 0;
            if (startIndex > input.Count - 1) startIndex = input.Count - 1;
            if (endIndex > input.Count - 1) endIndex = input.Count - 1;
            var temp = "";
            for (int i = startIndex; i <= endIndex ; i++)
            {
                temp += input[startIndex];
                input.RemoveAt(startIndex);
            }
            input.Insert(startIndex, temp);
        }

        private static void Divide(List<string> input, string v1, string v2)
        {
            var index = int.Parse(v1);
            var partitions = int.Parse(v2);
            var parts = input[index].Length / partitions;
            var temp = input[index];
            var number = 0;
            for (int i = parts; i < temp.Length; i += parts + 1)
            {
                if (number == partitions - 1) break;
                temp = temp.Insert(i, " ");
                number++;
            }
            var newTemp = temp.Split().ToList();
            input.RemoveAt(index);
            for (int i = 0; i < newTemp.Count; i++)
            {
                input.Insert(i + index, newTemp[i]);
            }
        }
    }
}
