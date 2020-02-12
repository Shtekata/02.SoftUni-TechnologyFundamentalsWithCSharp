using System;

namespace _04._Ceasar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var output = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                output += (char)(input[i] + 3);
            }
            Console.WriteLine(output);
        }
    }
}
