using System;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            var characterOne = char.Parse(Console.ReadLine());
            var characterTwo = char.Parse(Console.ReadLine());
            var result = CharactersBetweenOneAndTwo(characterOne, characterTwo);
            Console.WriteLine(result);
        }

        private static object CharactersBetweenOneAndTwo(char characterOne, char characterTwo)
        {
            char charFirst;
            char charSecond;
            if (characterOne > characterTwo) { charFirst = characterTwo; charSecond = characterOne; }
            else { charFirst = characterOne; charSecond = characterTwo; }
            var charStr = "";
            for (int i = charFirst + 1; i < charSecond; i++)
            {
                charStr += (char)i + " ";
            }
            return charStr;
        }
    }
}
