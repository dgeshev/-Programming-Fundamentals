using System;
using System.Linq;

namespace _02.IntegerInsertion
{
    public class IntegerInsertion
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var numAsString = Console.ReadLine();

            while (numAsString != "end")
            {
                int position = int.Parse(numAsString);
                int num = int.Parse(numAsString);

                while (Math.Abs(position) >= 10)
                {
                    position /= 10;
                }

                numbers.Insert(position, num);
                numAsString = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
