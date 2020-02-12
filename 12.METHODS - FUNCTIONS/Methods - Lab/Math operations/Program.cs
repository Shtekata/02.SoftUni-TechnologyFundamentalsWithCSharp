using System;

namespace Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = double.Parse(Console.ReadLine());
            var operatorNum = Console.ReadLine();
            var secondNumber = double.Parse(Console.ReadLine());
            var calculate = Calculate(firstNumber, operatorNum, secondNumber);
            Console.WriteLine(calculate);
        }

        private static object Calculate(double firstNumber, string operatorNum, double secondNumber)
        {
            var sum = 0.0;
            switch (operatorNum)
            {
                case "*": sum = firstNumber * secondNumber; break;
                case "/": sum = firstNumber / secondNumber; break;
                case "+": sum = firstNumber + secondNumber; break;
                case "-": sum = firstNumber - secondNumber; break;

            }
            return sum;
        }
    }
}
