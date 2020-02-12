using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            var vowel = NumberOfVowel(input);
            Console.WriteLine(vowel);
        }

        private static object NumberOfVowel(string input)
        {
            var sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u') sum++;
            }
            return sum;
        }
    }
}
