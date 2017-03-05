using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.LetterRepetition
{
 public   class LetterRepetition
    {
      public  static void Main()
        {
            var input = Console.ReadLine();
            var result = new Dictionary<char, int>();

            foreach (var ch in input)
            {
                if (!result.ContainsKey(ch))
                {
                    result[ch] = 1;
                }

                else
                {
                    result[ch]++;
                }
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
