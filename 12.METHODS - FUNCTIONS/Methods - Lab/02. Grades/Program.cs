using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Grades(double.Parse(Console.ReadLine()));
        }

        private static void Grades(double grade)
        {
            string gradeEvaluation = "";
            if (grade >= 2 && grade <= 2.99) gradeEvaluation="Fail";
            if (grade >= 3 && grade <= 3.49) gradeEvaluation="Poor";
            if (grade >= 3.5 && grade <= 4.49) gradeEvaluation="Good";
            if (grade >= 4.5 && grade <= 5.49) gradeEvaluation="Very good";
            if (grade >= 5.5 && grade <= 6) gradeEvaluation="Excellent";
            Console.WriteLine(gradeEvaluation);
        }
    }
}
