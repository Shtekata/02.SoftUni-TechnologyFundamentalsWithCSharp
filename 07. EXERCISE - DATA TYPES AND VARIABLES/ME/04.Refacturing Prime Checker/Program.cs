using System;

namespace _04.Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 2; i <= input; i++)
            {
                bool prime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                var output = string.Empty;
                if (prime) output = "true";
                else output = "false";
                Console.WriteLine($"{i} -> {output}");
            }
        }
    }
}
