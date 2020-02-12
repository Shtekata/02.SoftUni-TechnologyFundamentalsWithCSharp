using System;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var type = string.Empty;
            if (age >= 0 && age < 3) type = "baby";
            else if (age < 14) type = "child";
            else if (age < 20) type = "teenager";
            else if (age < 66) type = "adult";
            else type = "elder";
            Console.WriteLine(type);
        }
    }
}
