using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();
            var input = Console.ReadLine();
            while (input.ToLower() != "end")
            {
                var inputArr = input.Split(" : ");
                if (!courses.ContainsKey(inputArr[0])) courses[inputArr[0]] = new List<string>();
                courses[inputArr[0]].Add(inputArr[1]);
                input = Console.ReadLine();
            }
            var sortedCourses = courses.OrderByDescending(x => x.Value.Count);
            foreach (var item in sortedCourses)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                var sortedStudent = item.Value.OrderBy(x => x);
                foreach (var student in sortedStudent)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
