using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            var lostGames = int.Parse(Console.ReadLine());
            var headsetPrice = decimal.Parse(Console.ReadLine());
            var mousePrice = decimal.Parse(Console.ReadLine());
            var keyboardPrice = decimal.Parse(Console.ReadLine());
            var displayPrice = decimal.Parse(Console.ReadLine());

            var trashHeadset = lostGames / 2;
            var trashMouse = lostGames / 3;
            var trashKeyboard = lostGames / 6;
            var trashDisplay = lostGames / 12;

            var expenses = trashHeadset * headsetPrice + trashMouse * mousePrice + trashKeyboard * keyboardPrice + trashDisplay * displayPrice;
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
