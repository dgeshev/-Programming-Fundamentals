using System;

namespace _05.Triangle_Area
{
    class Program
    {
        public static double TriangleArea(double w, double h)
        {
            return (w * h) / 2;
        }

        public static void Main(string[] args)
        {
            var w = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var area = TriangleArea(w, h);
            Console.WriteLine(area);
        }
    }
}
