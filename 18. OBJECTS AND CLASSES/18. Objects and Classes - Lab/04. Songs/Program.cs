using System;
using System.Collections.Generic;

namespace _04._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfSongs = int.Parse(Console.ReadLine());
            Songs[] listOfSongs = new Songs[numberOfSongs];
            for (int i = 0; i < numberOfSongs; i++)
            {
                var data = Console.ReadLine().Split('_');
                listOfSongs[i] = new Songs(data[0], data[1], data[2]);
            }
            var typeList = Console.ReadLine();
            if (typeList == "all")
            {
                foreach (Songs item in listOfSongs)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else
            {
                foreach (Songs item in listOfSongs)
                {
                    if (typeList == item.TypeList)
                    {
                        Console.WriteLine(item.Name);
                    }
                }
            }
        }
    }
    class Songs
    {
        public Songs(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }

}
