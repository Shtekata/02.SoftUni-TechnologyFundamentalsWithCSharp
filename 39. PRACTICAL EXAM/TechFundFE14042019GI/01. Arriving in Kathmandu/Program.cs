using System;
using System.Text.RegularExpressions;

namespace _01._Arriving_in_Kathmandu
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            while (input!="Last note")
            {
                var inputRegex = @"^(?<first>[\w!@#$?]+)=\d+<<(?<second>[\w\W]+)$";
                var machInput = Regex.IsMatch(input, inputRegex);
                var mach = false;
                if (machInput)
                {
                    var input1 = input.Split("=");
                    var name = input1[0];
                    var input2 = input1[1];
                    var input3 = input2.Split("<<");
                    var length = int.Parse(input3[0]);
                    var code = input3[1];
                    if (length == code.Length)
                    {
                        var newName = string.Empty;
                        for (int i = 0; i < name.Length; i++)
                        {
                            if (char.IsLetterOrDigit(name[i])) newName += name[i];
                        }
                        Console.WriteLine($"Coordinates found! {newName} -> {code}");
                        mach = true;
                    }
                }
                if (!mach) Console.WriteLine($"Nothing found!");
                input = Console.ReadLine();
            }
        }
    }
}
