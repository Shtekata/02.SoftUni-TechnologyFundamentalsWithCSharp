using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            var day = Console.ReadLine();
            var price = 0.0;
            var allPrice = 0.0;
            switch (day)
            {
                case "Friday":
                    switch (type)
                    {
                        case "Students":price = 8.45;break;
                        case "Business":price = 10.9;break;
                        case "Regular":price = 15;break;
                    }break;
                case "Saturday":
                    switch (type)
                    {
                        case "Students": price = 9.80; break;
                        case "Business": price = 15.6; break;
                        case "Regular": price = 20; break;
                    }
                    break;
                case "Sunday":
                    switch (type)
                    {
                        case "Students": price = 10.46; break;
                        case "Business": price = 16; break;
                        case "Regular": price = 22.5; break;
                    }
                    break;
            }
            allPrice = number * price;
            if (type == "Students" && number > 29) allPrice *= 0.85;
            if (type == "Business" && number > 99) allPrice -= 10 * price;
            if (type == "Regular" && number > 9 && number < 21) allPrice *= 0.95;
            Console.WriteLine($"Total price: {allPrice:f2}");
        }
    }
}
