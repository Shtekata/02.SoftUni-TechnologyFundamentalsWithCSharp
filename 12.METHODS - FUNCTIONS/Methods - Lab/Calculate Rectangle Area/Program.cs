using System;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = TriangleArea(width, height);
            Console.WriteLine(area);
        }

        private static object TriangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
