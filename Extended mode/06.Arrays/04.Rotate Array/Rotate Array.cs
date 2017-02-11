using System;

namespace _04.Rotate_Array
{
    public class Program
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');

            var resulit = new string[words.Length];
            resulit[0] = words[words.Length - 1];

            for (int i = 0; i < words.Length - 1; i++)
            {
                resulit[i + 1] = words[i];
            }
            var finalResult = string.Join(" ", resulit);

            Console.WriteLine(finalResult);
        }
    }
}
