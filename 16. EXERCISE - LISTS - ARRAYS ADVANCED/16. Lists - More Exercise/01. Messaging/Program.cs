using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();
            var text = Console.ReadLine().Select(c => c.ToString()).ToList();
            var output = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                var sum = 0;
                var temp = input[i].Select(c => c.ToString()).Select(int.Parse).ToList();
                for (int j = 0; j < temp.Count; j++)
                {
                    sum += temp[j];
                }
                sum %= text.Count;
                output.Add(text[sum]);
                text.RemoveAt(sum);
            }
            Console.WriteLine(string.Join("",output));
        }
    }
}
