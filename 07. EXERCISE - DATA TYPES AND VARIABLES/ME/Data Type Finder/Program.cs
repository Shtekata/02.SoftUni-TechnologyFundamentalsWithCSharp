using System;

namespace Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var type = string.Empty;
            var floatingPoint = false;

            while (input != "END")
            {
                type = "";
                floatingPoint = false;
                if (input.Length < 1) type = "character";
                else if (input.Length == 1 && (char.Parse(input) < 48 || char.Parse(input) > 57)) type = "character";
                else if (input.ToLower() == "true" || input.ToLower() == "false") type = "boolean";
                else
                {
                    for (int i = 0; i <= input.Length - 1; i++)
                    {
                        if ((input[i] < 48 || input[i] > 57) && input[i] != 46 && input[i] != 45) { type = "string"; break; }
                        if (input[i] == 45 && i != 0) { type = "string"; break; }
                        if (input[i] == 46 && (i == 0 || i == input.Length - 1)) { type = "string"; break; }
                        if (input[i] == 46) floatingPoint = true;
                    }
                    if (type != "string" && floatingPoint) type = "floating point";
                    else if (type != "string") type = "integer";
                }
                Console.WriteLine($"{input} is {type} type");
                input = Console.ReadLine();
            }
        }
    }
}
