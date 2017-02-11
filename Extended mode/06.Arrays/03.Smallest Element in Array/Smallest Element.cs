using System;
using System.Linq;

namespace _03.Smallest_Element_in_Array
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var minValue = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]  < minValue)
                {
                    minValue = numbers[i];
                }
            }
            Console.WriteLine(minValue);
        }
    }
}
