using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine().ToLower();
            var input = Console.ReadLine();
            while (input.IndexOf(key)!=-1)
            {
                input = input.Remove(input.IndexOf(key), key.Length);
            }
            Console.WriteLine(input);
        }
    }
}
