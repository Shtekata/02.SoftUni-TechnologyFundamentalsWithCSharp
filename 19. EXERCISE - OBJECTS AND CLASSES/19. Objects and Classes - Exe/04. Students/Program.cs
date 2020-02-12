using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfStudents = int.Parse(Console.ReadLine());
            var students = new List<Students>();
            for (int i = 0; i < countOfStudents; i++)
            {
                var studentForm = Console.ReadLine().Split();
                var student = new Students(studentForm[0], studentForm[1], double.Parse(studentForm[2]));
                students.Add(student);
            }
            var newStudents = students.OrderByDescending(x => x.Grade);
            foreach (var item in newStudents)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Students
    {
        public Students()
        {
            FirstName = "";
            LastName = "";
            Grade = 0.0;
        }
        public Students(string firstName, string secondName, double grade)
        {
            FirstName = firstName;
            LastName = secondName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}
