using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FlipListSides
{
   public class FlipListSides
    {
       public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = new List<int>();

            result.Add(numbers[0]);

            for (int i = numbers.Count - 2; i > 0; i--)
            {
                result.Add(numbers[i]);
            }

            result.Add(numbers[numbers.Count - 1]);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
