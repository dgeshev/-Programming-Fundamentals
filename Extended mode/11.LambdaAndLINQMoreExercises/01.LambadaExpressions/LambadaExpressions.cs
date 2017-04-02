using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.LambadaExpressions
{
    public class LambadaExpressions
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var resultDict = new Dictionary<string, string>();

            while (input != "lambada")
            {
                var toknes = input.Split(new[] { ' ', '=', '>', }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (input != "dance")
                {
                    var leftPart = toknes[0];
                    var rightPart = toknes[1];

                    if (!resultDict.ContainsKey(leftPart))
                    {
                        resultDict[leftPart] = rightPart;
                    }

                    resultDict[leftPart] = rightPart;
                }

                else
                {
                    resultDict = resultDict.ToDictionary(x => x.Key, x => x.Key + '.' + x.Value);
                }

                input = Console.ReadLine();
            }

            foreach (var entry in resultDict)
            {
                Console.WriteLine($"{entry.Key} => {entry.Value}");

            }

        }
    }
}
