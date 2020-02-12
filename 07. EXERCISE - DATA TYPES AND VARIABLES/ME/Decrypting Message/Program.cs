using System;

namespace Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = int.Parse(Console.ReadLine());
            var number = int.Parse(Console.ReadLine());
            var message = string.Empty;

            for (int i = 0; i < number; i++)
            {
                var letter = char.Parse(Console.ReadLine());
                var letterEnd = (char)(letter + key);
                message += letterEnd;
            }
            Console.WriteLine(message);
        }
    }
}
