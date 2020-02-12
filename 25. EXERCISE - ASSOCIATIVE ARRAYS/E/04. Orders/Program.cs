using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var orders = new Dictionary<string, decimal[]>();
            var input = Console.ReadLine();
            while (input.ToLower() != "buy")
            {
                var inputArr = input.Split();
                var name = inputArr[0];
                var price = decimal.Parse(inputArr[1]);
                var quantity = decimal.Parse(inputArr[2]);
                if (!orders.ContainsKey(name)) orders[name] = new decimal[2];
                orders[name][0] = price;
                orders[name][1] += quantity;
                input = Console.ReadLine();
            }
            foreach (var item in orders)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0]*item.Value[1]:f2}");
            }
        }
    }
}
