using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = decimal.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var priceLightsaber = decimal.Parse(Console.ReadLine());
            var priceRobes = decimal.Parse(Console.ReadLine());
            var priceBelts = decimal.Parse(Console.ReadLine());

            var sumL = Math.Ceiling(students * 1.1m) * priceLightsaber;
            var sumR =  students * priceRobes;
            var sumB = (students - students / 6) * priceBelts;

            var sum = sumL + sumR + sumB;
            if (money >= sum) Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            else Console.WriteLine($"Ivan Cho will need {sum-money:f2}lv more.");
        }
    }
}
