using System;
using System.Linq;

namespace _03.EqualSumAfterExtraction
{
    public class EqualSumAfterExtraction
    {
        public static void Main()
        {
            var firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < firstList.Count; i++)
            {
                if (secondList.Contains(firstList[i]))
                {
                    secondList.Remove(firstList[i]);
                }
            }

            if (firstList.Sum() == secondList.Sum())
            {
                Console.WriteLine($"Yes. Sum: {firstList.Sum()}");
            }
            else 
            {
                Console.WriteLine($"No. Diff: {Math.Abs(firstList.Sum() - secondList.Sum())}");
            }
        }
    }
}
