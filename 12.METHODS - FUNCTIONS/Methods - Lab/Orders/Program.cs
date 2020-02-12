using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            TotalPrice(product, quantity);
        }

        private static void TotalPrice(string product, int quantity)
        {
            var price = 0.0m;
            switch (product)
            {
                case "coffee": price = 1.5m; break;
                case "water": price = 1m; break;
                case "coke": price = 1.4m; break;
                case "snacks": price = 2m; break;
            }
            var totalPrice = quantity * price;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
