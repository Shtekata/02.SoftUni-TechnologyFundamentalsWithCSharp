using System;

namespace Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = Console.ReadLine().ToLower();
            var age = int.Parse(Console.ReadLine());
            var price = 0;

            if (age < 0 || age > 122) Console.WriteLine("Error!");
            else
            {
                switch (day)
                {
                    case "weekday": if (age < 19 || (age > 64 && age < 123)) price = 12; else price = 18; break;
                    case "weekend": if (age < 19 || (age > 64 && age < 123)) price = 15; else price = 20; break;
                    case "holiday": if (age < 19) price = 5; else if (age < 64) price = 12; else price = 10; break;
                }
                Console.WriteLine($"{price}$");
            }
        }
    }
}







