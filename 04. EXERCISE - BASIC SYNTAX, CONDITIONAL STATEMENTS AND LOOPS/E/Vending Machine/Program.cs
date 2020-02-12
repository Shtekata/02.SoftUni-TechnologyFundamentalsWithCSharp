using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            var coin = 0.0;
            var sumCoin = 0.0;
            var input = Console.ReadLine();
            while (input != "Start")
            {
                coin = double.Parse(input);
                if (coin != 0.1 && coin != 0.2 && coin != 0.5 && coin != 1 && coin != 2) Console.WriteLine($"Cannot accept {coin}");
                else sumCoin += coin;
                input = Console.ReadLine();

            }
            var nuts = 2.0;
            var water = 0.7;
            var crisps = 1.5;
            var soda = 0.8;
            var coke = 1.0;
            var product = string.Empty;
            var purch = false;
            var noInvalid = true;
            input = Console.ReadLine();
            while (input!="End")
            {
                purch = false;
                switch (input)
                {
                    case "Nuts": if (sumCoin >= nuts) { sumCoin -= nuts; product = "nuts"; purch = true; } break;
                    case "Water": if (sumCoin >= water) { sumCoin -= water; product = "water"; purch = true; } break;
                    case "Crisps": if (sumCoin >= crisps) { sumCoin -= crisps; product = "crisps"; purch = true; } break;
                    case "Soda": if (sumCoin >= soda) { sumCoin -= soda; product = "soda"; purch = true; } break;
                    case "Coke": if (sumCoin >= coke) { sumCoin -= coke; product = "coke"; purch = true; } break;
                    default:
                        Console.WriteLine($"Invalid product"); noInvalid = false;
                        break;
                }
                if (noInvalid)
                {
                    if (purch) Console.WriteLine($"Purchased {product}"); else Console.WriteLine($"Sorry, not enough money");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sumCoin:f2}");
        }
    }
}
