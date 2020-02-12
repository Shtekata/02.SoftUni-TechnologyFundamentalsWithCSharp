using System;
using System.Collections.Generic;
using System.Linq;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCommands = int.Parse(Console.ReadLine());
            var guests = new List<string>();
            for (int i = 0; i < numberOfCommands; i++)
            {
                var guest = Console.ReadLine().Split().ToList();
                if (guest.Count == 3) { if (guests.Contains(guest[0])) Console.WriteLine($"{guest[0]} is already in the list!"); else guests.Add(guest[0]); }
                else
                { if (guests.Contains(guest[0])) guests.Remove(guest[0]); else Console.WriteLine($"{guest[0]} is not in the list!"); }
            }
            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
            }
        }
    }
}
