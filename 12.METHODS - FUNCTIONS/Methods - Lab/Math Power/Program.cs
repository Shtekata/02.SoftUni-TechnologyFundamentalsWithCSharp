using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var power = double.Parse(Console.ReadLine());
            var matPower = MathPower(number, power);
            Console.WriteLine(matPower);
        }

        private static object MathPower(double number, double power)
        {
            var result = 1.0;
            for (int i = 0; i < power; i++)
            {
                if (power >= 0) { result *= number; }
                else result = 1 / result * number;
            }
            return result;
        }
    }
}
