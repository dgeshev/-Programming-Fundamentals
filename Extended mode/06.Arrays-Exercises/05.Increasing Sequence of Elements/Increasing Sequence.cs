using System;
using System.Linq;

namespace _05.Increasing_Sequence_of_Elements
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isIncreasing = true;
            var previous = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] <= previous)
                {
                    isIncreasing = false;
                    break;
                }
                previous = numbers[i];
            }
            if (isIncreasing)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
