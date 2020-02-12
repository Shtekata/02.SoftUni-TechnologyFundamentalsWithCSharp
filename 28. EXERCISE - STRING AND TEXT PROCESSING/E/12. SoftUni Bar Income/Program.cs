using System;
using System.Text.RegularExpressions;

namespace _12._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var allPrice = 0.0m;
            while (input != "end of shift")
            {
                var restricted = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[0-9]+\.?[0-9]+?)\$";
                if (Regex.IsMatch(input, restricted))
                {
                    var newInput = Regex.Match(input, restricted);
                    var customer = newInput.Groups["customer"].Value;
                    var product = newInput.Groups["product"].Value;
                    var count = newInput.Groups["count"].Value;
                    var price = newInput.Groups["price"].Value;
                    var totalPrice = decimal.Parse(count) * decimal.Parse(price);
                    Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
                    allPrice += totalPrice;
                }
                input = Console.ReadLine(); 
            }
            Console.WriteLine($"Total income: {allPrice:f2}");
        }
    }
}
