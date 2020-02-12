using System;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var handOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            var handTwo = Console.ReadLine().Split().Select(int.Parse).ToList();
            var handMin = Math.Min(handOne.Count, handTwo.Count);
            while (handMin > 0)
            {
                if (handOne[0] > handTwo[0])
                { handOne.Add(handOne[0]); handOne.Add(handTwo[0]); handOne.RemoveAt(0); handTwo.RemoveAt(0); }
                else if (handOne[0] < handTwo[0])
                { handTwo.Add(handTwo[0]); handTwo.Add(handOne[0]); handOne.RemoveAt(0); handTwo.RemoveAt(0); }
                else { handOne.RemoveAt(0); handTwo.RemoveAt(0); }
                handMin = Math.Min(handOne.Count, handTwo.Count);
            }
            var winner = handOne;
            var player = "First";
            if (handTwo.Count > handOne.Count) { winner = handTwo; player = "Second"; }
            var sum = 0;
            for (int i = 0; i < winner.Count; i++)
            {
                sum += winner[i];
            }
            Console.WriteLine($"{player} player wins! Sum: {sum}");
        }
    }
}
