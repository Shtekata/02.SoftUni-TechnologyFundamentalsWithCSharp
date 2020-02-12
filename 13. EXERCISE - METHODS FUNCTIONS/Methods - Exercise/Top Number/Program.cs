using System;

namespace Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                if (MasterNumber(i)) Console.WriteLine(i);
            }
        }

        private static bool MasterNumber(int number)
        {
            var topNumber = false;
            var odd = false;
            var sum = 0;
            var newNumber = new int[number.ToString().Length];
            for (int i = newNumber.Length - 1; i >= 0; i--)
            {
                newNumber[i] = number % 10;
                number /= 10;
            }
            for (int i = 0; i < newNumber.Length; i++)
            {
                sum += newNumber[i];
                if (newNumber[i] % 2 == 1) odd = true;
            }
            if (odd && sum % 8 == 0) topNumber = true;
            return topNumber;
        }
    }
}
