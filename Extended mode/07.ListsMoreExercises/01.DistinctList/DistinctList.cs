using System;
using System.Linq;

namespace _01.DistinctList
{
    public class DistinctList
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var newNumbers = numbers.Distinct().ToList();

            Console.WriteLine(string.Join(" ", newNumbers));
        }
    }
}
