using System;

namespace _05.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var startChar = int.Parse(Console.ReadLine());
            var endChar = int.Parse(Console.ReadLine());
            for (int i = startChar; i <= endChar; i++)
            {
                Console.Write((char)i+" ");
            }
            Console.WriteLine();
        }
    }
}
