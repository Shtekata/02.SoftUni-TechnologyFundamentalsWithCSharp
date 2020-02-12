using System;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    var a = int.Parse(Console.ReadLine()); var b = int.Parse(Console.ReadLine());
                    var greater = GreatIntChar(a, b); Console.WriteLine(greater); break;
                case "char":
                    a = char.Parse(Console.ReadLine()); b = char.Parse(Console.ReadLine());
                    greater = GreatIntChar(a, b); Console.WriteLine((char)greater); break;
                case "string":
                    var c = Console.ReadLine(); var d = Console.ReadLine();
                    var greaterS = GreatString(c, d); Console.WriteLine(greaterS); break;

            }
        }

        private static string GreatString(string c, string d)
        {
            if (c[0] > d[0]) return c;
            else return d;
        }

        private static int GreatIntChar(int a, int b)
        {
            if (a > b) return a;
            else return b;
        }
    }
}
