using System;

namespace Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbOne = Console.ReadLine();
            var numbTwo = Console.ReadLine();
            var lenght = 0;
            if (numbOne.Length > numbTwo.Length) lenght = numbOne.Length;
            else lenght = numbTwo.Length;
            var equal = true;
            var eps = 0;
            var floatP = false;
            for (int i = 0; i < lenght; i++)
            {
                if ((numbOne[0] == 45 && numbOne[1] == 48 && numbOne[3] == 48 && numbOne[4] == 48 && numbOne[5] == 48 && numbOne[6] == 48 && numbOne[7] == 48 && numbOne[8] == 48) || (numbTwo[0] == 45 && numbTwo[1] == 48 && numbTwo[3] == 48 && numbTwo[4] == 48 && numbTwo[5] == 48 && numbTwo[6] == 48 && numbTwo[7] == 48 && numbTwo[8] == 48)) equal =true;
                if (numbOne[i] != numbTwo[i]) equal = false;
                if (numbOne[i] == 46) floatP = true;
                if(floatP) eps++;
                if (eps > 6) break;
            }
            Console.WriteLine(equal);
        }
    }
}
