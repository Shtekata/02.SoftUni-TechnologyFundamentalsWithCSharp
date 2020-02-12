using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var students = new Dictionary<string, int>();
            var courses = new Dictionary<string, int>();
            while (input != "exam finished")
            {
                var inputLine = input.Split("-");
                var name = inputLine[0];
                var language = inputLine[1];
                if (language == "banned") students.Remove(name);
                else
                {
                    var points = int.Parse(inputLine[2]);
                    if (!students.ContainsKey(name)) students[name] = 0;
                    if (students[name] < points) students[name] = points;
                    if (!courses.ContainsKey(language)) courses[language] = 0;
                    courses[language]++;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Results:");
            foreach (var item in students.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
            Console.WriteLine($"Submissions:");
            foreach (var item in courses.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
