using System;
using System.Collections.Generic;

namespace _01.SerializeString
{
    public class SerializeString
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = new Dictionary<char, List<int>>();

            for (int i = 0; i < input.Length; i++)
            {

                if (!result.ContainsKey(input[i]))
                {
                    result[input[i]] = new List<int>();                   
                }

                result[input[i]].Add(i);
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key}:{string.Join("/", kvp.Value)}");
            }
        }
    }
}
