using System;

namespace _01.Largest_Element
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var array = new int[n];
            var maxNumber = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                var currentnumber = int.Parse(Console.ReadLine());

                array[i] = currentnumber;

                if (array[i] > maxNumber)
                {
                    maxNumber = array[i];
                }
            }

            Console.WriteLine(maxNumber);
        }
    }
}
