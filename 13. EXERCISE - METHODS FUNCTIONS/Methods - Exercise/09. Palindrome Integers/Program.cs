using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            while (input != "END")
            {
                var inputInt = int.Parse(input);
                Console.WriteLine(Palindrome(inputInt).ToString().ToLower());
                input = Console.ReadLine();
            }
        }

        private static bool Palindrome(int inputInt)
        {
            var inputArr = new int[inputInt.ToString().Length];
            for (int i = inputArr.Length - 1; i >= 0; i--)
            {
                inputArr[i] = inputInt % 10;
                inputInt /= 10;
            }
            var pali = true;
            for (int i = 0; i < inputArr.Length / 2; i++)
            {
                if (inputArr[i] != inputArr[inputArr.Length - 1 - i]) { pali = false; break; }
            }
            return pali;
        }
    }
}
