using System;

namespace Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentName = Console.ReadLine();
            var studentAge = Console.ReadLine();
            var studentGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {studentName}, Age: {studentAge}, Grade: {studentGrade:f2}");
        }
    }
}
