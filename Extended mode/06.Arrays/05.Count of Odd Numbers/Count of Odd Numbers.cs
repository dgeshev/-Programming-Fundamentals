using System;
using System.Linq;

namespace _05.Count_of_Odd_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var reminder = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    reminder++;
                }
            }
            Console.WriteLine(reminder);
        }
    }
}
