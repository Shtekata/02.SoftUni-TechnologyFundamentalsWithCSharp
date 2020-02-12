using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Vapor_Winter_Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var games = new Dictionary<string, decimal>();
            var gamesDlc = new Dictionary<string, Dictionary<string,decimal>>();

            var inputNew = input.Split(", ");

            foreach (var item in inputNew)
            {
                if (item.Contains('-'))
                {
                    var newItem = item.Split('-');
                    if (!games.ContainsKey(newItem[0]))
                    {
                        games.Add(newItem[0], decimal.Parse(newItem[1]));
                    }
                }
                else
                {
                    item.Split(':');
                    var newItem = item.Split(':');
                    if (games.ContainsKey(newItem[0]))
                    {
                        var price = games[newItem[0]];
                        var newAtrr = new Dictionary<string, decimal>();
                        newAtrr.Add(newItem[1], price);
                        gamesDlc.Add(newItem[0], newAtrr);
                        games.Remove(newItem[0]);
                    }
                }
            }
            var newGames = new Dictionary<string, decimal>();
            foreach (var item in games)
            {
                newGames.Add(item.Key, item.Value * 0.8m);
            }
            var newGamesDlc = new Dictionary<string, Dictionary<string, decimal>>();
            foreach (var item in gamesDlc)
            {
                var dlc = item.Value.Keys.First();
                var cost = item.Value.Values.First() * 1.2m / 2;
                var dict = new Dictionary<string, decimal>();
                dict.Add(dlc, cost);
                newGamesDlc.Add(item.Key, dict);
            }
            foreach (var item in newGamesDlc.OrderBy(x=>x.Value.Values.First()))
            {

                Console.WriteLine($"{item.Key} - {item.Value.Keys.First()} - {item.Value.Values.First():f2}");
            }
            foreach (var item in newGames.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"{item.Key} - {item.Value:f2}");
            }
        }
    }
}
