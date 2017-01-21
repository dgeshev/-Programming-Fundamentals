using System;

namespace _02.Circle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            double r = double.Parse(Console.ReadLine());
            double result = Math.PI * r * r;
            Console.WriteLine("{0:f12}", result);
        }
    }
}
