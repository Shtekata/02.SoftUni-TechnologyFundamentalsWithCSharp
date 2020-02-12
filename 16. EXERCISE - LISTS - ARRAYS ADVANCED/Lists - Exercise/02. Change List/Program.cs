using System;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var command = Console.ReadLine().Split().ToList();
            while (command[0]!="end")
            {
                if (command.Count == 2) input.RemoveAll(n => n == int.Parse(command[1]));
                else input.Insert(int.Parse(command[2]), int.Parse(command[1]));
                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
