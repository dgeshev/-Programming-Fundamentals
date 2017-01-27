using System;

namespace _02.Sign_of_Integer_Number
{
    public class Program
    {
        static void PrintNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintNumber(n);
        }
    }
}
