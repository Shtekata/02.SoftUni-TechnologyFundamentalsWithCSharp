using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var persons = new List<Persons>();
            while (input != "End")
            {
                var inputArray = input.Split();
                var person = new Persons(inputArray[0], inputArray[1], inputArray[2]);
                persons.Add(person);
                input = Console.ReadLine();
            }
            var orderedPersons = persons.OrderBy(x => x.Age);
            foreach (var item in orderedPersons)
            {
                Console.WriteLine(persons.Find(x => x == item));
            }
        }
    }
    class Persons
    {
        public Persons(string name, string id, string age)
        {
            Name = name;
            ID = int.Parse(id);
            Age = int.Parse(age);
        }
        public string Name;
        public int ID;
        public int Age;
        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
