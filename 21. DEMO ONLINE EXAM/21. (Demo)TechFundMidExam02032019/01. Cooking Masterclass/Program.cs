using System;

namespace _01._Cooking_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            var budjed = decimal.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var priceForFlour = decimal.Parse(Console.ReadLine());
            var priceForEgg = decimal.Parse(Console.ReadLine());
            var priceForApron = decimal.Parse(Console.ReadLine());

            var priceEgg = 10 * priceForEgg * students;
            var priceFlour = priceForFlour * (students - students / 5);
            var priceApron = priceForApron * Math.Ceiling(students * 1.2m);

            var sum = priceEgg + priceFlour + priceApron;

            if (sum > budjed) Console.WriteLine($"{sum - budjed:f2}$ more needed.");
            else Console.WriteLine($"Items purchased for {sum:f2}$.");
        }
    }
}
