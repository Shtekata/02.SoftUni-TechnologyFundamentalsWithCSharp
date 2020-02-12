using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<double>>();
            for (int i = 0; i < number; i++)
            {
                var student = Console.ReadLine();
                var grade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(student)) students[student] = new List<double>();
                students[student].Add(grade);
            }
            var sortedStudents = students
                .OrderByDescending(x => x.Value.Sum() / x.Value.Count)
                .Where(x => x.Value.Sum() / x.Value.Count >= 4.5);
            foreach (var item in sortedStudents)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Sum() / item.Value.Count:f2}");
            }
        }
    }
}
