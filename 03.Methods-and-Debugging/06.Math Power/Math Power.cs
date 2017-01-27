using System;

namespace _06.Math_Power
{
    class Program
    {
        public static double RaiseToPower(double a, double b)
        {
            double result = 0;
            result = Math.Pow(a, b);
            return result;         
        }

       public static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPower(a, b));
        }
    }
}
