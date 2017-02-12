using System;
using System.Linq;

namespace _03.Count_of_Given_Element
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var element = int.Parse(Console.ReadLine());
            var count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == element)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
