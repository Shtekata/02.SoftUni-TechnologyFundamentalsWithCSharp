using System;
using System.Linq;
namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var field = new int[number];
            int[] bugs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < bugs.Length; j++)
                {
                    if (i == bugs[j]) { field[i] = 1; break; } else field[i] = 0;
                }
            }
            var input = Console.ReadLine().ToLower();
            var position = -1;
            var move = -1;
            while (input != "end")
            {
                var inputNew = input.Split().ToArray();
                position = int.Parse(inputNew[0]);
                if (position >= 0 && position < field.Length)
                    if (field[position] == 1)
                    {
                        field[position] = 0;
                        move = int.Parse(inputNew[2]);
                        if (inputNew[1] == "right") position += move;
                        else if (inputNew[1] == "left") position -= move;
                        while (position>=0 && position < field.Length)
                        {
                            if (field[position] == 0) { field[position] = 1; break; }
                            if (inputNew[1] == "right") position+=move; else position-=move;
                        }
                    }
                input = Console.ReadLine().ToLower();
            }
            Console.WriteLine(string.Join(' ', field));
        }
    }
}
