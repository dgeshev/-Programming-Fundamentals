using System;
using System.Linq;

namespace _02.Multiply_an_Array
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var p = double.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= p;
            }

            var result = string.Join(" ", numbers);

            Console.WriteLine(result);
        }
    }
}
