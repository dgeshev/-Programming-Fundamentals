using System;

namespace _02.Count_of_Negative_Elements
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var array = new int[n];
            var sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                array[i] = currentNumber;

                if (array[i] < 0)
                {
                    sum ++;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
