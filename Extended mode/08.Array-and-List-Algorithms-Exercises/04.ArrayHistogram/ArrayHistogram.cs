using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ArrayHistogram
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToList();
            var words = new Dictionary<string, int>();
            
            for (int i = 0; i < input.Count; i++)
            {
                if (!words.ContainsKey(input[i]))
                {
                    words.Add(input[i] , 1);
                }
                else
                {
                    words[input[i]]++;
                }
            }
            var sumValue = 0;

            foreach (var kvp in words)
            {
                sumValue += kvp.Value;
            }

            words
                .OrderByDescending(x => x.Value)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Key} -> {x.Value} times ({x.Value * 100.00 /sumValue:f2}%)"));
        }
    }
}
