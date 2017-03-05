using System;
using System.Linq;

namespace _02.AverageCharacterDelimiter
{
    public class AverageCharacterDelimiter
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var inputArray = input.Split(' ').ToArray();
            double sum = 0;
            var count = 0;

            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] != ' ')
                {
                    var currentIndex = (double)input[i];
                    sum += currentIndex;
                    count++;
                }
            }

            var divided = (int)(sum / count);
            var delimited = (char)divided;
            var ch = char.ToUpper(delimited);
            Console.WriteLine(string.Join($"{ch}", inputArray));

        }
    }
}
