using System;
using System.Linq;

namespace _03.Camel_sBack
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int number = int.Parse(Console.ReadLine());
            var count = 0;

            if (input.Count == number)
            {
                Console.WriteLine($"already stable: {string.Join(" ", input)}");
            }
            else
            {
                while (input.Count > number)
                {
                    input.Remove(input[0]);
                    input.Remove(input[input.Count - 1]);

                    count++;
                }

                Console.WriteLine($"{count} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", input)}");
            }
            
        }
    }
}
