using System;


namespace _03.Printing_Triangle
{
    public class Program
    {
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static void Triangle(int n)
        {
            for (int line = 1; line <= n; line++)
            {
                PrintLine(1, line);
            }

            for (int line = n - 1; line >= 1; line--)
            {
                PrintLine(1, line);
            }
        }

        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            Triangle(num);
        }
    }
}
