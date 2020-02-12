using System;
using System.Linq;

namespace _03._The_Final_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();
            var command = Console.ReadLine().Split();

            while (command[0] != "Stop")
            {
                switch (command[0])
                {
                    case "Delete": if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < input.Count - 1) input.RemoveAt(int.Parse(command[1]) + 1); break;
                    case "Swap":
                        if (input.Contains(command[1]) && input.Contains(command[2]))
                        {
                            var firstIndex = input.IndexOf(command[1]);
                            var secondIndex = input.IndexOf(command[2]);
                            var temp = input[firstIndex];
                            input[firstIndex] = input[secondIndex];
                            input[secondIndex] = temp;
                        }
                        break;
                    case "Put":
                        if (int.Parse(command[2]) - 1 > 0 && int.Parse(command[2]) - 1 <= input.Count)
                            input.Insert(int.Parse(command[2]) - 1, command[1]); break;
                    case "Sort": input.Sort(); input.Reverse(); break;
                    case "Replace":
                        if (input.Contains(command[2]))
                        {
                            var secondIndex = input.IndexOf(command[2]);
                            input[secondIndex] = command[1];
                        }
                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(' ', input));
        }
    }
}
