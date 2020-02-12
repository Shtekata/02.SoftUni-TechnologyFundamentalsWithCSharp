using System;
using System.Linq;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var inputA = input.ToString().ToArray();
            var inpAZ = inputA[1];
            var inp = inpAZ-48;
            Console.WriteLine(inp);
        }
    }
}
