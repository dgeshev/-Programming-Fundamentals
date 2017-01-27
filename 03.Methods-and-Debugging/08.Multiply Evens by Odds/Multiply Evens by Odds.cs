using System;

namespace _08.Multiply_Evens_by_Odds
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine(getMultiplyOfEvensAndOdds(n));
        }

        public static int getMultiplyOfEvensAndOdds(int n)
        {
            int sumOfEvens = getSumOfEvensDigit(n);
            int sumOfOdds = getSumOfOddsDigit(n);
            return sumOfEvens * sumOfOdds;
        }

        public static int getSumOfOddsDigit(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }

                n /= 10;
            }
            return sum;
        }

        public static int getSumOfEvensDigit(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }

                n /= 10;
            }
            return sum;
        }

    }
}
