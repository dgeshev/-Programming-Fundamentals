using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Boxes
{

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static double CalcDistance(Point p1, Point p2)
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }

    public class Box
    {
        public Point UpperLeft { get; set; }
        public Point UpperRight { get; set; }
        public Point BottonLeft { get; set; }
        public Point BottomRight { get; set; }

        public static int CalcPerimeter(int width, int height)
        {
            return ((2 * width) + (2 * height));
        }

        public static int CalcArea(int width, int height)
        {
            return (width * height);
        }
    }

    public class Boxes
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var boxes = new List<Box>();

            while (input != "end")
            {
                var splittedInput = input.Split(new[] { ' ', ':', '|' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToList();
                var newBox = new Box();

                newBox.UpperLeft = ReadPoint(splittedInput[0], splittedInput[1]);
                newBox.UpperRight = ReadPoint(splittedInput[2], splittedInput[3]);
                newBox.BottonLeft = ReadPoint(splittedInput[4], splittedInput[5]);
                newBox.BottomRight = ReadPoint(splittedInput[6], splittedInput[7]);

                boxes.Add(newBox);

                input = Console.ReadLine();
            }

            foreach (var box in boxes)
            {
                var width = Point.CalcDistance(box.UpperLeft, box.UpperRight);
                var height = Point.CalcDistance(box.BottonLeft, box.UpperLeft);

                Console.WriteLine($"Box: {width}, {height}");
                Console.WriteLine($"Perimeter: {Box.CalcPerimeter((int)width, (int)height)}");
                Console.WriteLine($"Area: {Box.CalcArea((int)width, (int)height)}");
            }

        }

        public static Point ReadPoint(int x1, int x2)
        {
            var point = new Point
            {
                X = x1,
                Y = x2
            };
            return point;
        }
    }
}
