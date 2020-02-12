using System;

namespace Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());
            int maxNumber = Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber));
            int minNumber = Math.Min(firstNumber, Math.Min(secondNumber, thirdNumber));
            int middleNumber = 0;
            if ((firstNumber == maxNumber || firstNumber == minNumber) && (secondNumber == maxNumber || secondNumber == minNumber && firstNumber != secondNumber)) middleNumber = thirdNumber;
            else if ((secondNumber == maxNumber || secondNumber == minNumber) && (thirdNumber == maxNumber || thirdNumber == minNumber && secondNumber != thirdNumber)) middleNumber = firstNumber;
            else middleNumber = secondNumber;
            Console.WriteLine(maxNumber);
            Console.WriteLine(middleNumber);
            Console.WriteLine(minNumber);
        }
    }
}
