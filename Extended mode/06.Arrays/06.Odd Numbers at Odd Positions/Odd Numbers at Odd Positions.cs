using System;
using System.Linq;

namespace _06.Odd_Numbers_at_Odd_Positions
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 != 0 && numbers[i] % 2 != 0)
                {
                    Console.WriteLine($"Index {i} -> {numbers[i]}");
                }
            }

        }
    }
}
