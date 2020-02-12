using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            var scheduleLessons = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            var input = Console.ReadLine();
            var exercise = "";
            while (input != "course start")
            {
                string[] inputS = input.Split(':');
                var indexS1 = scheduleLessons.IndexOf(inputS[1]) + 1;
                var exerciseS1 = false;
                if (indexS1 < scheduleLessons.Count) exerciseS1 = scheduleLessons[indexS1].Split('-').Length == 2;
                if (!scheduleLessons.Contains(inputS[1]))
                {
                    if (inputS[0] == "Add") scheduleLessons.Add(inputS[1]);
                    else if (inputS[0] == "Insert" && int.Parse(inputS[2]) >= 0 && int.Parse(inputS[2]) < scheduleLessons.Count) scheduleLessons.Insert(int.Parse(inputS[2]), inputS[1]);
                }
                if (inputS[0] == "Remove")
                {
                    if (scheduleLessons.Contains(inputS[1]))
                    {
                        scheduleLessons.Remove(inputS[1]);
                        if (exerciseS1) scheduleLessons.RemoveAt(indexS1 - 1);
                    }
                }
                else if (inputS[0] == "Swap" && scheduleLessons.Contains(inputS[1])
                    && scheduleLessons.Contains(inputS[2]))
                {
                    var indexS2 = scheduleLessons.IndexOf(inputS[2]) + 1;
                    var exerciseS2 = false;
                    if (indexS2 < scheduleLessons.Count) exerciseS2 = scheduleLessons[indexS2].Split('-').Length == 2;
                    Swap(indexS1, exerciseS1, indexS2, exerciseS2, scheduleLessons);
                }
                else if (inputS[0] == "Exercise")
                {
                    exercise = inputS[1] + "-" + "Exercise";
                    if (scheduleLessons.Contains(inputS[1]))
                    {
                        if (scheduleLessons.IndexOf(inputS[1]) == scheduleLessons.Count - 1) scheduleLessons.Add(exercise);
                        else if (scheduleLessons[indexS1].Split('-').Length < 2) scheduleLessons.Insert(indexS1, exercise);
                    }
                    else if (!scheduleLessons.Contains(inputS[1]))
                    {
                        scheduleLessons.Add(inputS[1]);
                        scheduleLessons.Add(exercise);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var item in scheduleLessons)
            {
                Console.WriteLine($"{scheduleLessons.IndexOf(item) + 1}.{item}");
            }
        }
        private static void Swap(int indexS1, bool exerciseS1, int indexS2, bool exerciseS2, List<string> scheduleLessons)
        {
            var temp = scheduleLessons[indexS1 - 1];
            scheduleLessons.Insert(indexS1 - 1, scheduleLessons[indexS2 - 1]);
            scheduleLessons.RemoveAt(indexS1);
            scheduleLessons.Insert(indexS2 - 1, temp);
            scheduleLessons.RemoveAt(indexS2);
            var maxIndex = Math.Max(indexS1, indexS2);
            if (maxIndex == indexS2)
            {
                if (exerciseS1)
                {
                    scheduleLessons.Insert(indexS2, scheduleLessons[indexS1]);
                    scheduleLessons.RemoveAt(indexS1);
                }
                if (exerciseS2)
                {
                    scheduleLessons.Insert(indexS1, scheduleLessons[indexS2]);
                    scheduleLessons.RemoveAt(indexS2 + 1);
                }
            }
            else
            {
                if (exerciseS2)
                {
                    scheduleLessons.Insert(indexS1, scheduleLessons[indexS2]);
                    scheduleLessons.RemoveAt(indexS2);
                }
                if (exerciseS1)
                {
                    scheduleLessons.Insert(indexS2, scheduleLessons[indexS1]);
                    scheduleLessons.RemoveAt(indexS1 + 1);
                }
            }
        }
    }

}

