using System;
using System.Linq;

namespace _03.SortArrayOfStrings
{
    public class SortArrayOfStrings
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToList();
            bool sorted = false;

            do
            {
                sorted = false;

                for (int i = 0; i < input.Count - 1; i++)
                {
                    var cuerrentWord = input[i];
                    var nextWord = input[i + 1];
                    int compareValue = cuerrentWord.CompareTo(nextWord);

                    if (compareValue > 0)
                    {
                        input[i] = nextWord;
                        input[i + 1] = cuerrentWord;

                        sorted = true;
                    }
                }
            } while (sorted);

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
