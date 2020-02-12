using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());
            var smallest = SmallestNumber(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(smallest);
        }

        private static object SmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            int small;
            if (firstNumber < secondNumber && firstNumber < thirdNumber) small = firstNumber;
            else if (secondNumber < firstNumber && secondNumber < thirdNumber) small = secondNumber;
            else small = thirdNumber;
            return small;
        }
    }
}
