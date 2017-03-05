using System;
using System.Collections.Generic;

namespace _03.MixedPhones
{
   public class MixedPhones
    {
       public static void Main()
        {
            var resultDict = new SortedDictionary<string, double>();
            var input = Console.ReadLine();

            while (input != "Over")
            {
                var token = input.Trim().Split();
                var firstElement = token[0];
                var lastElement = token[token.Length - 1];

                double number = 0;

                if (double.TryParse(lastElement, out number))
                {
                    resultDict[firstElement] = number;
                }

                else
                {
                    resultDict[lastElement] = double.Parse(firstElement);
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in resultDict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
