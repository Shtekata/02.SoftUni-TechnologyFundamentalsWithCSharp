using System;
using System.Linq;

namespace _12._Array_Manipulator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var command = Console.ReadLine().Split();
            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "exchange": input = Excehange(input, command[1]); break;
                    case "max": MaxEvenOdd(input, command[1]); break;
                    case "min": MinEvenOdd(input, command[1]); break;
                    case "first": FirstEvenOdd(input, command[1], command[2]); break;
                    case "last": LastEvenOdd(input, command[1], command[2]); break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine($"[{string.Join(", ", input)}]");
        }

        private static void LastEvenOdd(int[] input, string v1, string v2)
        {
            var lastOdd = new int[input.Length];
            var lastEven = new int[input.Length];
            var counter = 0;
            var number = int.Parse(v1);
            if (number > input.Length) { Console.WriteLine($"Invalid count"); return; }

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] % 2 == 1 && v2 == "odd") { lastOdd[counter] = input[i]; counter++; }
                if (input[i] % 2 == 0 && v2 == "even") { lastEven[counter] = input[i]; counter++; }
            }

            var output = new int[Math.Min(counter, number)];
            var counter2 = 0;

            for (int i = output.Length - 1; i >= 0; i--)
            {
                if (v2 == "odd") { output[counter2] = lastOdd[i]; counter2++; }
                else { output[i] = lastEven[counter2]; counter2++; }
            }

            Console.WriteLine($"[{string.Join(", ", output)}]");
        }

        private static void FirstEvenOdd(int[] input, string v1, string v2)
        {
            var firstOdd = new int[input.Length];
            var firstEven = new int[input.Length];
            var counter = 0;
            var number = int.Parse(v1);
            if (number > input.Length) { Console.WriteLine($"Invalid count"); return; }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 1 && v2 == "odd") { firstOdd[counter] = input[i]; counter++; }
                if (input[i] % 2 == 0 && v2 == "even") { firstEven[counter] = input[i]; counter++; }
            }

            var output = new int[Math.Min(counter, number)];

            for (int i = 0; i < output.Length; i++)
            {
                if (v2 == "odd") output[i] = firstOdd[i];
                else output[i] = firstEven[i];
            }

            Console.WriteLine($"[{string.Join(", ", output)}]");
        }

        private static void MinEvenOdd(int[] input, string v)
        {
            var divisionResult = 0;
            if (v == "odd") divisionResult = 1;
            var min = 1001;
            var index = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == divisionResult && input[i] <= min) { min = input[i]; index = i; }
            }
            if (min != 1001) Console.WriteLine(index);
            else Console.WriteLine($"No matches");
        }

        private static void MaxEvenOdd(int[] input, string v)
        {
            var divisionResult = 0;
            if (v == "odd") divisionResult = 1;
            var max = -1;
            var index = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == divisionResult && input[i] >= max) { max = input[i]; index = i; }
            }
            if (max != -1) Console.WriteLine(index);
            else Console.WriteLine($"No matches");

        }

        private static int[] Excehange(int[] input, string v)
        {
            var index = int.Parse(v);
            if (index >= input.Length || index < 0) { Console.WriteLine($"Invalid index"); return input; }
            for (int i = 0; i <= index; i++)
            {
                var temp = input[0];
                for (int j = 0; j < input.Length - 1; j++)
                {
                    input[j] = input[j + 1];
                }
                input[input.Length - 1] = temp;
            }
            return input;
        }
    }
}
