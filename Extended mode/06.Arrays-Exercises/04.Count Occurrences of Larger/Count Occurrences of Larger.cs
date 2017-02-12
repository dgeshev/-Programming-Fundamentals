using System;
using System.Linq;

namespace _04.Count_Occurrences_of_Larger
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var p = double.Parse(Console.ReadLine());
            var count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > p)
                {
                    count++;
                }
            }

            Console.WriteLine(count);

        }
    }
}
