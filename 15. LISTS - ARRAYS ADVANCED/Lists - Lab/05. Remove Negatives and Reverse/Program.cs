using System;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            input.RemoveAll(a => a < 0);
            input.Reverse();
            if (input.Count > 0) Console.WriteLine(string.Join(" ",input));
            else Console.WriteLine($"empty");
        }
    }
}
