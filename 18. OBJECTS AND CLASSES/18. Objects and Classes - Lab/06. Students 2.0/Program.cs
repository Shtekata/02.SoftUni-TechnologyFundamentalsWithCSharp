using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var scheme = new List<Students>();

            while (input != "end")
            {
                var newInput = input.Split();
                var temp = new Students(newInput[0], newInput[1], newInput[2], newInput[3]);
                var doNotExist = true;
                for (int i = 0; i < scheme.Count; i++)
                {
                    if (scheme[i].FirstName == temp.FirstName && scheme[i].LastName == temp.LastName)
                    {
                        scheme[i].Age = temp.Age; scheme[i].HomeTown = scheme[i].HomeTown; doNotExist = false;
                    }
                }
                if (doNotExist) scheme.Add(temp);
                input = Console.ReadLine();
            }
            var nameOfTheCity = Console.ReadLine();
            List<Students> sortList = scheme.Where(s => s.HomeTown == nameOfTheCity).ToList();
            foreach (Students item in sortList)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
            }
        }
    }
    class Students
    {
        public Students(string firstName, string lastName, string age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }
        public string FirstName;
        public string LastName;
        public string Age;
        public string HomeTown;
    }
}
