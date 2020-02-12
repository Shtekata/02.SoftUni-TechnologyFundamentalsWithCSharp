using System;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }
    }
}
