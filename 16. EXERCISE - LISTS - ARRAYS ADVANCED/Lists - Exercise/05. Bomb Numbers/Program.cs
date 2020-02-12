using System;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var first = false;
            if (input.Count < 2) first = true;
            var bomb = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < input.Count; i++)
            {
                if (bomb[1] < 0) bomb[1] = 0;
                var start = i - bomb[1];
                if (start < 0) start = 0;
                var end = i + bomb[1];
                if (end > input.Count) end = input.Count - 1;
                if (input[i] == bomb[0])
                {
                    for (int j = start; j <= end; j++)
                    {
                        if (i - bomb[1] >= 0) input.RemoveAt(i - bomb[1]); else input.RemoveAt(0);
                    }
                    i = -1;
                }
            }
            var sum = 0;
            if (!first)
            {
                for (int i = 0; i < input.Count; i++)
                {
                    sum += input[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
