using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Seize_the_Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('#').ToArray();
            var water = int.Parse(Console.ReadLine());
            var effort = 0.0;
            var fire = 0;
            var output = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                var cell = input[i].Split(" = ");
                var number = int.Parse(cell[1]);
                if (cell[0] == "High" && number > 80 && number < 126 && water >= number)
                {
                    water -= number;
                    effort += number * 0.25;
                    output.Add(number);
                    fire += number;
                }
                else if (cell[0] == "Medium" && number > 50 && number < 81 && water >= number)
                {
                    water -= number;
                    effort += number * 0.25;
                    output.Add(number);
                    fire += number;

                }
                else if (cell[0] == "Low" && number > 0 && number < 51 && water >= number)
                {
                    water -= number;
                    effort += number * 0.25;
                    output.Add(number);
                    fire += number;
                }
            }
            Console.WriteLine($"Cells:");
            foreach (var item in output)
            {
                Console.WriteLine($"- {item}");
            }
            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: {fire}");
        }
    }
}
