using System;
using System.Linq;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var inside = new Rectangle(input[0], input[1], input[2], input[3], input[4], input[5]);
            Console.WriteLine(inside.IsInside());
            Console.WriteLine(inside.CalcArea());
        }
    }
    class Rectangle
    {
        public Rectangle(double top, double left, double width, double height, double dotHorizontally, double dotVertically)
        {
            Top = top;
            Left = left;
            Width = width;
            Height = height;
            DotHorizontally = dotHorizontally;
            DotVertically = dotVertically;
        }

        public double Top { get; set; }
        public double Left { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Bottom { get { return Top + Height; } }
        public double Right { get { return Left + Width; } }
        public double DotHorizontally { get; set; }
        public double DotVertically { get; set; }

        public double CalcArea()
        {
            return Width * Height;
        }

        public bool IsInside()
        {
            return (Left <= DotHorizontally) && (Right >= DotHorizontally) && (Top <= DotVertically) && (Bottom >= DotVertically);
        }
    }
}
