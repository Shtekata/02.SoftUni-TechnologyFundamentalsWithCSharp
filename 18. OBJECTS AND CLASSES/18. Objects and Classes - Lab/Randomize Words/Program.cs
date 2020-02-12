using System;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split();
            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
                var pos2 = new Random().Next(words.Length);

                var temp = words[pos1];
                words[pos1] = words[pos2];
                words[pos2] = temp;
            }
            Console.WriteLine(string.Join('\n',words));
        }
    }
}
