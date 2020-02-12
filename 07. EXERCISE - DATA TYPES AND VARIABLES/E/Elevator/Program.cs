using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = int.Parse(Console.ReadLine());
            var capacity = double.Parse(Console.ReadLine());

            double courses = Math.Ceiling(persons / capacity);
            Console.WriteLine(courses);
        }
    }
}
