using System;

namespace Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            var moneyIn = decimal.Parse(Console.ReadLine());
            var money = moneyIn;
            var input = string.Empty;
            var price = 0m;
            input = Console.ReadLine();
            while (input != "Game Time")
            {
                var notDef = true;
                switch (input)
                {
                    case "OutFall 4": price = 39.99m; break;
                    case "CS: OG": price = 15.99m; break;
                    case "Zplinter Zell": price = 19.99m; break;
                    case "Honored 2": price = 59.99m; break;
                    case "RoverWatch": price = 29.99m; break;
                    case "RoverWatch Origins Edition": price = 39.99m; break;
                    default:
                        Console.WriteLine($"Not Found"); notDef = false;
                        break;
                }
                if (notDef)
                {
                    if (money >= price) { money -= price; Console.WriteLine($"Bought {input}"); }
                    else Console.WriteLine($"Too Expensive");
                    if (money == 0) { Console.WriteLine($"Out of money!"); break; }
                }
                input = Console.ReadLine();
            }
            if (money != 0) Console.WriteLine($"Total spent: ${moneyIn - money:f2}. Remaining: ${money}");
        }
    }
}
