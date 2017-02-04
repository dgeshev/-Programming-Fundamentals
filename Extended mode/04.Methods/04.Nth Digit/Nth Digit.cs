using System;

namespace _04.Nth_Digit
{
    public class Program
    {
        public static int FindNthDigit(long num, int index)
        {
            var currentIndex = 1;
            while (num > 0)
            {
                if (currentIndex == index)
                {
                    return (int)(num % 10);
                }
                currentIndex++;
                num /= 10;
            }
            return (index % 10);
        }

        public static void Main(string[] args)
        {
            var num = long.Parse(Console.ReadLine());
            var index = int.Parse(Console.ReadLine());

            var ResultDigit = FindNthDigit(num, index);
            Console.WriteLine(ResultDigit);
        }
    }
}
