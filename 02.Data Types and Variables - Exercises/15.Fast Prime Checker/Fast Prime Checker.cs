using System;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 2; i <= number; i++)
            {
                bool isPrime = true;
                for (int divisor = 2; divisor <= Math.Sqrt(i); divisor++)
                {
                    if (i % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine($"{i} -> {isPrime}"); }
        }
    }
}
