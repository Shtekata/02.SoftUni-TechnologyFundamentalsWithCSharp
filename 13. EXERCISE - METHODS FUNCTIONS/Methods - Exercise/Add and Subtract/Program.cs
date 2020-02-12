using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumb = int.Parse(Console.ReadLine());
            var secondNumb = int.Parse(Console.ReadLine());
            var thirdNumb = int.Parse(Console.ReadLine());

            var sumNumb = Sum(firstNumb, secondNumb);
            var subtrNum = SubtractSum(sumNumb, thirdNumb);
            Console.WriteLine(subtrNum);
        }

        private static object SubtractSum(int sumNumb, int thirdNumb)
        {
            var subtract = sumNumb - thirdNumb;
            return subtract;
        }

        private static int Sum(int firstNumb, int secondNumb)
        {
            var sum = firstNumb + secondNumb;
            return sum;
        }
    }
}
