using System;
using System.Linq;
namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var input = Console.ReadLine();
            while (input != "end")
            {
                var command = input.Split().ToArray();
                if (command[0] == "exchange" && int.Parse(command[1]) <= inputArr.Length - 1)
                    inputArr = Exchange(command[1], inputArr);
                else if (command[0] == "exchange" && int.Parse(command[1]) > inputArr.Length - 1) Console.WriteLine($"Invalid index");
                if (input == "max odd" || input == "max even" || input == "min odd" || input == "min even")
                    MaxMin(inputArr, input);
                if ((command[0] == "first" || command[0] == "last") && (command[2] == "odd" || command[2] == "even")
                    && int.Parse(command[1]) <= inputArr.Length)
                    FirstLast(inputArr, command[0], command[1], command[2]);
                else if ((command[0] == "first" || command[0] == "last") && (command[2] == "odd" || command[2] == "even")
                    && int.Parse(command[1]) > inputArr.Length) Console.WriteLine($"Invalid count");


                input = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", inputArr)}]");
        }

        private static void FirstLast(int[] inputArr, string v1, string v2, string v3)
        {
            var odd = new int[inputArr.Length];
            var numberOdd = 0;
            var even = new int[inputArr.Length];
            var numberEven = 0;
            var currentNumber = 0;
            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] % 2 == 1) { odd[numberOdd] = inputArr[i]; numberOdd++; }
                else { even[numberEven] = inputArr[i]; numberEven++; }
            }

            var currentArr = new int[inputArr.Length];
            if (v3 == "odd") { currentArr = odd; currentNumber = numberOdd; }
            else { currentArr = even; currentNumber = numberEven; }
            var length = int.Parse(v2);
            var newArr = new int[Math.Min(currentNumber, length)];
            var min = 0;
            var max = 0;
            if (length > inputArr.Length) Console.WriteLine($"Invalid count");
            else if (length > currentNumber)
            {
                for (int i = 0; i < currentNumber; i++)
                {
                    newArr[i] = currentArr[i];
                }
            }
            else
            {
                if (v1 == "first") { min = 0; max = length; }
                else { min = newArr.Length - length; max = newArr.Length; }
                for (int i = min; i < max; i++)
                {
                    newArr[i] = currentArr[i];
                }
            }
            Console.WriteLine($"[{string.Join(", ",newArr)}]");
        }
        private static void MaxMin(int[] inputArr, string input)
        {
            var maxOdd = -1;
            var maxOddIndex = -1;
            var maxEven = -1;
            var maxEvenIndex = -1;
            var minOdd = 1001;
            var minOddIndex = 1001;
            var minEven = 1001;
            var minEvenIndex = 1001;
            var output = 0;
            var exist = true;
            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] % 2 == 1 && inputArr[i] > maxOdd) { maxOdd = inputArr[i]; maxOddIndex = i; }
                if (inputArr[i] % 2 == 1 && inputArr[i] < minOdd) { minOdd = inputArr[i]; minOddIndex = i; }
                if (inputArr[i] % 2 == 0 && inputArr[i] > maxEven) { maxEven = inputArr[i]; maxEvenIndex = i; }
                if (inputArr[i] % 2 == 0 && inputArr[i] < minEven) { minEven = inputArr[i]; minEvenIndex = i; }
            }
            if (input == "max odd") if (maxOdd != -1) output = maxOddIndex; else exist = false;
            if (input == "max even") if (maxEven != -1) output = maxEvenIndex; else exist = false;
            if (input == "min odd") if (minOdd != 1001) output = minOddIndex; else exist = false;
            if (input == "min even") if (minEven != 1001) output = minEvenIndex; else exist = false;

            if (exist) Console.WriteLine(output);
            else Console.WriteLine($"No matches");

        }

        private static int[] Exchange(string v, int[] inputArr)
        {
            var exchangeArr = new int[inputArr.Length];
            var exchange = int.Parse(v) + 1;
            var exch = 0;
            for (int i = 0; i < inputArr.Length; i++)
            {
                if (i + exchange > inputArr.Length - 1) exch = i + exchange - inputArr.Length;
                else exch = exchange + i;
                exchangeArr[i] = inputArr[exch];
            }
            return exchangeArr;
        }
    }
}
