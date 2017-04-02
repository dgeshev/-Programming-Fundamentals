using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.DefaultValues
{
    public class DefaultValues
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var resultDict = new Dictionary<string, string>();

            while (input != "end")
            {
                var tokens = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                var firstWord = tokens[0];
                var secondWord = tokens[1];

                if (!resultDict.ContainsKey(firstWord))
                {
                    resultDict[firstWord] = secondWord;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            var unchangedDict = resultDict.Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            var changedDict = resultDict.Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => input);

            foreach (var item in unchangedDict)
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }

            foreach (var item in changedDict)
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }
        }
    }
}
