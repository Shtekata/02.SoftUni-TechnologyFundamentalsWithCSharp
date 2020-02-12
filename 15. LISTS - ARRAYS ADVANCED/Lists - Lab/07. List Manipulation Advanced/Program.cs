using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var originalInput = Console.ReadLine();
            var input = originalInput.Split().Select(int.Parse).ToList();
            var command = Console.ReadLine();
            while (command != "end")
            {
                var commandList = command.Split().ToList();
                switch (commandList[0])
                {
                    case "Add": input.Add(int.Parse(commandList[1])); break;
                    case "Remove": input.Remove(int.Parse(commandList[1])); break;
                    case "RemoveAt": input.RemoveAt(int.Parse(commandList[1])); break;
                    case "Insert": input.Insert(int.Parse(commandList[2]), int.Parse(commandList[1])); break;
                    case "Contains": if (input.Contains(int.Parse(commandList[1]))) Console.WriteLine("Yes"); else Console.WriteLine("No such number"); break;
                    case "PrintEven": PrintEvenOdd(input, commandList[0]); break;
                    case "PrintOdd": PrintEvenOdd(input, commandList[0]); break;
                    case "GetSum": GetSum(input); break;
                    case "Filter": Filter(commandList[1], int.Parse(commandList[2]), input); break;
                }
                command = Console.ReadLine();
            }
            if (string.Join(" ", input) != originalInput) Console.WriteLine(string.Join(" ", input));
        }

        private static void Filter(string v, int numberTwo, List<int> input)
        {
            var newList = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] < numberTwo && v == "<" || input[i] > numberTwo && v == ">" || input[i] <= numberTwo && v == "<=" || input[i] >= numberTwo && v == ">=") newList.Add(input[i]);
            }
            Console.WriteLine(string.Join(" ", newList));
        }

        private static void GetSum(List<int> input)
        {
            long sum = 0;
            for (int i = 0; i < input.Count; i++)
            {
                sum += input[i];
            }
            Console.WriteLine(sum);
        }

        private static void PrintEvenOdd(List<int> input, string command)
        {
            var evenNumbers = new List<int>();
            var oddNumbers = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 == 0) evenNumbers.Add(input[i]);
                else oddNumbers.Add(input[i]);
            }
            if (command == "PrintEven") Console.WriteLine(string.Join(" ", evenNumbers));
            else Console.WriteLine(string.Join(" ", oddNumbers));
        }
    }
}
