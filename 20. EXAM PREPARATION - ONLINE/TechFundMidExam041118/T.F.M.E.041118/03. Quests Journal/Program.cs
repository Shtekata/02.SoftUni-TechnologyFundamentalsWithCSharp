using System;
using System.Linq;

namespace _03._Quests_Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            var adventurerPath = Console.ReadLine().Split(", ").ToList();
            var commands = Console.ReadLine().Split(" - ");
            while (commands[0] != "Retire!")
            {
                if (commands[0] == "Start" && !adventurerPath.Contains(commands[1]))
                    adventurerPath.Add(commands[1]);
                if (commands[0] == "Complete" && adventurerPath.Contains(commands[1]))
                    adventurerPath.Remove(commands[1]);
                if (commands[0] == "Side Quest")
                {
                    var side = commands[1].Split(':');
                    var index = adventurerPath.IndexOf(side[0])+1;
                    if (adventurerPath.Contains(side[0]) && !adventurerPath.Contains(side[1]))
                    {
                        if (index != adventurerPath.Count) adventurerPath.Insert(index, side[1]);
                        else adventurerPath.Add(side[1]);
                    }
                }
                if (commands[0] == "Renew" && adventurerPath.Contains(commands[1]))
                { adventurerPath.Remove(commands[1]); adventurerPath.Add(commands[1]); }
                commands = Console.ReadLine().Split(" - ");

            }
            Console.WriteLine(string.Join(", ",adventurerPath));
        }
    }
}
