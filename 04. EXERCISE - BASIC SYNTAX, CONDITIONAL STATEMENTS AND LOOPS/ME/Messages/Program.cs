using System;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var letter = 0;
            var sms = string.Empty;
            for (int i = 0; i < input; i++)
            {
                var digit = Console.ReadLine();
                var digLength = digit.Length;
                var digSingle = int.Parse(digit) % 10;
                if (digSingle == 0) letter = 32;
                else
                {
                    var offset = (digSingle - 2) * 3;
                    letter = offset + digLength + 96;
                    if (digSingle > 7) letter++;
                }
                sms += (char)letter;
            }
            Console.WriteLine(sms);
        }
    }
}
