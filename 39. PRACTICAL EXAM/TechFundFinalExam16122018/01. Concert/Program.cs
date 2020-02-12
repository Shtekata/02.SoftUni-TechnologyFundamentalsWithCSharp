using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var bandArtists = new Dictionary<string, List<string>>();
            var timeArtist = new Dictionary<string, double>();
            var totalTime = 0;

            while (input!="start of concert")
            {
                var newInput = input.Split("; ");
                if (newInput[0] == "Play")
                {
                    if (timeArtist.ContainsKey(newInput[1]))
                    {
                        timeArtist[newInput[1]] += int.Parse(newInput[2]);
                    }
                    else timeArtist.Add(newInput[1], int.Parse(newInput[2]));
                    totalTime += int.Parse(newInput[2]);
                }
                else
                {
                    var artists = newInput[2].Split(", ").ToList();
                    if (!bandArtists.ContainsKey(newInput[1]))
                    {
                        bandArtists.Add(newInput[1], artists);
                    }
                    else
                    {
                        foreach (var item in artists)
                        {
                            if (!bandArtists[newInput[1]].Contains(item))
                            {
                                bandArtists[newInput[1]].Add(item);
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }
            var bandToPrint = Console.ReadLine();
            Console.WriteLine($"Total time: {totalTime}");
            var sortedBand = timeArtist.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            foreach (var item in sortedBand)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            Console.WriteLine(bandToPrint);
            foreach (var item in bandArtists[bandToPrint])
            {
                Console.WriteLine($"=> {item}");
            }
        }
    }
}
