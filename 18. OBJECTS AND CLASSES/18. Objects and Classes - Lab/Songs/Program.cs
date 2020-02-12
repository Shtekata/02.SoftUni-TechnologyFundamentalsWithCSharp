using System;

namespace Songs
{
    class StartUp
    {
        public static void Main()
        {
            var dice1 = new Dice();
            var dice2 = new Dice(567);
            var dice = new Dice();
            dice.Sides = 200;
            Console.WriteLine(dice1.Roll());
            Console.WriteLine(dice2.Roll());
            Console.WriteLine(dice.Roll());
        }
    }
    class Dice
    {
        public Dice()
        {
            this.Sides = 6;
        }
        public Dice(int sides)
        {
            this.Sides = sides;
        }
        public int Sides { get; set; }
        public int Roll()
        {
            var rnd = new Random();
            return rnd.Next(1, Sides + 1);
        }
    }
}
