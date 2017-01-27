using System;

namespace _04.Draw_a_Filled_Square
{
    public class Program
    {
        public static void PrintHeaderEnd(int n)
        {
            Console.WriteLine(new string ('-', n * 2));
        }

        public static void printBody(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }


       public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintHeaderEnd(n);
            for (int i = 0; i < n - 2 ; i++)
            {
                printBody(n);
            }
            PrintHeaderEnd(n);
        }
    }
}
