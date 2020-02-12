using System;
using System.Text.RegularExpressions;

namespace _02._Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            while (input.ToLower() != "end")
            {
                var regex = @"(?<artist>[A-Z][a-z ']*):(?<song>[A-Z ]+)";
                var mached = Regex.Match(input, regex);
                var inputMached = mached.ToString();
                if (input == inputMached)
                {
                    var artSong = inputMached.Split(':');
                    var key = artSong[0].Length;
                    var encryptedString = string.Empty;
                    for (int i = 0; i < inputMached.Length; i++)
                    {
                        var symbol = inputMached[i];
                        if ((symbol > 64 && symbol < 91) || (symbol > 96 && symbol < 123))
                        {
                            if (symbol + key > 90 && symbol + key < 97 + key || symbol + key > 122) symbol = (char)(symbol - 26);
                            encryptedString += (char)(symbol + key);
                        }
                        else
                        {
                            if (symbol == 58) symbol = (char)64;
                            encryptedString += symbol;
                        }
                    }
                    Console.WriteLine($"Successful encryption: {encryptedString}");
                }
                else Console.WriteLine($"Invalid input!");
                input = Console.ReadLine();
            }
        }
    }
}
