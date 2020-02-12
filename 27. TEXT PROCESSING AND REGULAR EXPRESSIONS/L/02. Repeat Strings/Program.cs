using System;
using System.Text;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split();
            var result = new StringBuilder();
            foreach (var item in words)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    result.Append(item);
                }
            }
            Console.WriteLine(result);
        }
    }
}
