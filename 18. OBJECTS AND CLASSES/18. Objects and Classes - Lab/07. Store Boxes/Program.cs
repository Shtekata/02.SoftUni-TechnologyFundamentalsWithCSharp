using System;
using System.Collections.Generic;

namespace _07._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputOriginal = Console.ReadLine();
            var table = new List<Box>();
            while (inputOriginal.ToLower() != "end")
            {
                var input = inputOriginal.Split();
                var item = new Item(input[1], decimal.Parse(input[3]));
                var box = new Box(input[0], item, int.Parse(input[2]));
                table.Add(box);
                inputOriginal = Console.ReadLine();
            }
            var newTable = new List<Box>();
            var iMax = table.Count;
            for (int i = 0; i < iMax; i++)
            {
                var maxPrise = 0m;
                var maxPriseItem = new Box();
                foreach (var item in table)
                {
                    if (item.PriceForABox > maxPrise) { maxPrise = item.PriceForABox; maxPriseItem = item; }
                }
                newTable.Add(maxPriseItem);
                table.Remove(maxPriseItem);
            }
            foreach (Box item in newTable)
            {
                Console.WriteLine(item.SerialNumber);
                Console.WriteLine($"-- {item.Item.Name} - ${item.Item.Price:f2}: {item.ItemQuantity}");
                Console.WriteLine($"-- ${item.PriceForABox:f2}");
            }
        }
    }
    class Item
    {
        public Item()
        {
            Name = "";
            Price = 0m;
        }
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name;
        public decimal Price;
    }
    class Box
    {
        public Box()
        {
            SerialNumber = "";
            Item = new Item();
            ItemQuantity = 0;
            PriceForABox = 0m;
        }
        public Box(string serialNumber, Item item, int itemQuantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
            PriceForABox = PriceBox();
        }
        public string SerialNumber;
        public Item Item;
        public int ItemQuantity;
        public decimal PriceForABox;

        public decimal PriceBox()
        {
            var price = ItemQuantity * Item.Price;
            return price;
        }
    }
}
