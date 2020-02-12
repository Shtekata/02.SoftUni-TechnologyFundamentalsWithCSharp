using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine().Split(", ");
            var input = Console.ReadLine();
            foreach (var item in bannedWords)
            {
                input = input.Replace(item, new string('*', item.Length));
            }
            Console.WriteLine(input);
        }
    }
}
