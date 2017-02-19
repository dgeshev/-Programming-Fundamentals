using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Remove_Elements_at_Odd_Positions
{
    public class Program
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(' ').ToList<string>();
            var onlyEvenWords = new List<string>();

            for (int i = 1; i < words.Count; i+=2)
            {
                    onlyEvenWords.Add(words[i]);
            }

            Console.WriteLine(string.Join("", onlyEvenWords));
        }
    }
}
