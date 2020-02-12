using System;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var textNumber = Console.ReadLine();
            var number = int.Parse(textNumber);
            var number2 = number;
            var currentNumber = 0;
            var strongNumber = 0;
            for (int i = 0; i < textNumber.Length; i++)
            {
                currentNumber = number2 % 10;
                var currentFactorial = currentNumber;
                var loopNumber = currentNumber;
                if (currentNumber == 0 || currentNumber == 1) currentFactorial = 1;
                else for (int j = 1; j < loopNumber; j++)
                    {
                        currentFactorial *= currentNumber - 1;
                        currentNumber--;
                    }
                strongNumber += currentFactorial;
                number2 = number2 / 10;
            }
            if (strongNumber == number) Console.WriteLine("yes");
            else Console.WriteLine("no");
        }
    }
}
