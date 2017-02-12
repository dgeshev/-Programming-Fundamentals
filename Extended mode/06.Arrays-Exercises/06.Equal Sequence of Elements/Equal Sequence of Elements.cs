using System;
using System.Linq;

namespace _06.Equal_Sequence_of_Elements
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isEqual = true;
            var previous = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] != previous)
                {
                    isEqual = false;
                    break;
                }
                previous = numbers[i];
            }

            if (isEqual)
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
