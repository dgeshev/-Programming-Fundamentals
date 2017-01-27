using System;

namespace _07.Greater_of_Two_Values
{
    class Program
    {
        public static int GetMax(int first, int second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        public static char GetMax(char first, char second)
        {
            if (first >= second)
            {
                return first;
            }

            else
            {
                return second;
            }
        }

        public static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            return second;
        }

        public static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                var first = Console.ReadLine();
                var second = Console.ReadLine();
                var max = GetMax(first, second);
                Console.WriteLine(max);
            }

            else if (type == "string")
            {
                var first = Console.ReadLine();
                var second = Console.ReadLine();
                var max = GetMax(first, second);
                Console.WriteLine(max);
            }
        }
    }
}
