using System;
using System.Linq;

namespace _02.Elements_Equal_to_Their_Index
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers[i])
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
    }
}
