using System;

namespace _02.Min_Method
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMin(a, b, c));
        }

        public static int GetMin(int a, int b, int c)
        {
            int result = 0;

            if (a <= b && a < c)
            {
                result = a;
            }

            else if (b < a && b <= c)
            {
                result = b;
            }

            else
            {
                result = c;
            }

            return result;
        }
    }
}
