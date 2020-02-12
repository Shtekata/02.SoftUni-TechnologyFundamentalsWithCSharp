using System;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var command = Console.ReadLine();
            while (command != "end")
            {
                var commandList = command.Split().ToList();
                var numberOne = int.Parse(commandList[1]);
                var numberTwo = 0;
                if (commandList.Count > 2) numberTwo = int.Parse(commandList[2]);
                switch (commandList[0])
                {
                    case "Add": input.Add(numberOne); break;
                    case "Remove": input.Remove(numberOne); break;
                    case "RemoveAt": input.RemoveAt(numberOne); break;
                    case "Insert": input.Insert(numberTwo, numberOne); break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
