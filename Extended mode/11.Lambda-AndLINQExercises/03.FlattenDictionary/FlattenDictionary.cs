using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.FlattenDictionary
{
    public class FlattenDictionary
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var resultDict = new Dictionary<string, Dictionary<string, string>>();

            while (input != "end")
            {
                var tokens = input.Split(' ').ToList();

                if (tokens[0] != "flatten")
                {
                    var key = tokens[0];
                    var innerKey = tokens[1];
                    var innerValue = tokens[2];

                    if (!resultDict.ContainsKey(key))
                    {
                        resultDict.Add(key, new Dictionary<string, string>());
                    }

                        resultDict[key][innerKey] = innerValue;

                }

                else
                {
                    var key = tokens[1];

                    resultDict[key] = resultDict[key]
                        .ToDictionary(x => x.Key + x.Value, x => "flattened");
                }

                input = Console.ReadLine();
            }

            var unflattenDict = resultDict.OrderByDescending(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var entry in unflattenDict)
            {
                Console.WriteLine($"{entry.Key}");

                var innerDict = entry.Value.Where(x => x.Value != "flattened").OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                var flattenValues = entry.Value.Where(x => x.Value == "flattened")
                  .ToDictionary(x => x.Key, x => x.Value);

                var count = 1;

                foreach (var innerEntry in innerDict)
                {
                    Console.WriteLine($"{count}. {innerEntry.Key} - {innerEntry.Value}");
                    count++;
                }
            
                foreach (var flattenedEntry in flattenValues)
                {
                    Console.WriteLine($"{count}. {flattenedEntry.Key}");
                    count++;
                }
               
            }          
        }
    }
}
