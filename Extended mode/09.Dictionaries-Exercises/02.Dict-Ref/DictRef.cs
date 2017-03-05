using System;
using System.Collections.Generic;

namespace _02.Dict_Ref
{
    public class DictRef
    {
        public static void Main()
        {
            var resultDict = new Dictionary<string, int>();
            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split();
                var firstElement = tokens[0];
                var lastElement = tokens[tokens.Length - 1];

                var number = 0;

                if (int.TryParse(lastElement, out number))
                {
                    resultDict[firstElement] = number;
                }

                else
                {
                    if (resultDict.ContainsKey(lastElement))
                    {
                        var referencedValue = resultDict[lastElement];
                        resultDict[firstElement] = referencedValue;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in resultDict)
            {
                Console.WriteLine($"{kvp.Key} === {kvp.Value}");
            }

        }
    }
}
