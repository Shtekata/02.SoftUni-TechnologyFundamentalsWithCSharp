using System;
using System.Text;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new StringBuilder(Console.ReadLine());
            var delete = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    delete = input[i + 1] - 48;
                    if (delete > input.Length - i - 1) delete = input.Length - i - 1;
                    for (int j = delete; j > 0; j--)
                    {
                        if (input[i + 1] == '>')
                        {
                            j += input[i + 2] - 47;
                            if (j > input.Length - i - 1) j = input.Length - i - 1;
                            i++;
                        }
                        else if (i + 1 < input.Length) input.Remove(i + 1, 1);
                    }
                }
            }
            Console.WriteLine(input);
        }
    }
}
