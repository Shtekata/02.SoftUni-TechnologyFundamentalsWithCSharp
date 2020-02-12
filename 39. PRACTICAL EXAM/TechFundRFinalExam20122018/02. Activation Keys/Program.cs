using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToUpper().Split('&');
            var output = new List<string>();
            var shortPattern = @"\w{16}";
            var longPattern = @"\w{25}";
            foreach (var item in input)
            {
                var newItem = string.Empty;
                foreach (char symbol in item)
                {
                    if (char.IsDigit(symbol))
                    {
                        var newSymbol = ' ';
                        switch (symbol)
                        {
                            case '0': newSymbol = '9'; break;
                            case '1': newSymbol = '8'; break;
                            case '2': newSymbol = '7'; break;
                            case '3': newSymbol = '6'; break;
                            case '4': newSymbol = '5'; break;
                            case '5': newSymbol = '4'; break;
                            case '6': newSymbol = '3'; break;
                            case '7': newSymbol = '2'; break;
                            case '8': newSymbol = '1'; break;
                            case '9': newSymbol = '0'; break;
                        }
                        newItem += newSymbol;
                    }
                    else newItem += symbol;
                }
                if (Regex.IsMatch(newItem, longPattern))
                {
                    var item1 = newItem.Substring(0, 5);
                    var item2 = newItem.Substring(5, 5);
                    var item3 = newItem.Substring(10, 5);
                    var item4 = newItem.Substring(15, 5);
                    var item5 = newItem.Substring(20);
                    var newKey = $"{item1}-{item2}-{item3}-{item4}-{item5}";
                    output.Add(newKey);
                }
                else if (Regex.IsMatch(newItem, shortPattern))
                {
                    var item1 = newItem.Substring(0, 4);
                    var item2 = newItem.Substring(4, 4);
                    var item3 = newItem.Substring(8, 4);
                    var item4 = newItem.Substring(12);
                    var newKey = $"{item1}-{item2}-{item3}-{item4}";
                    output.Add(newKey);
                }
                
            }
            Console.WriteLine(string.Join(", ",output));
        }
    }
}
