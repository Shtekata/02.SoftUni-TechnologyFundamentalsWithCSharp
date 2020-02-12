using System;
using System.Linq;

namespace _02._Santa_s_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('&').ToList();
            var commands = Console.ReadLine().Split();
            while (commands[0]!="Finished!")
            {
                if (commands[0] == "Bad" && !input.Contains(commands[1])) input.Insert(0, commands[1]);
                if (commands[0] == "Good") input.Remove(commands[1]);
                if (commands[0] == "Rename")
                {
                    if (input.Contains(commands[1])) { input[input.IndexOf(commands[1])] = commands[2]; }
                }
                if (commands[0] == "Rearrange" && input.Contains(commands[1]))
                {
                    input.Remove(commands[1]);
                    input.Add(commands[1]);
                }
                commands = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(", ",input));
        }
    }
}
