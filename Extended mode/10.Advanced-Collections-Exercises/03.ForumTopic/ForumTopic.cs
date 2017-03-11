using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ForumTopic
{
    public class ForumTopic
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var resultDict = new Dictionary<string, HashSet<string>>();

            while (input != "filter")
            {
                var tokens = input.Split(new[] { ' ', '>', '-', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim()).ToList(); 
                var name = tokens[0];
                for (int i = 0; i < tokens.Count - 1; i++)
                {
                    if (!resultDict.ContainsKey(name))
                    {
                        resultDict[name] = new HashSet<string>();
                    }

                    resultDict[name].Add(tokens[i + 1]);
                }

                input = Console.ReadLine();
            }

            var filtred = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim()).ToList();

            foreach (var kvp in resultDict)
            {
                var isAllContained = !filtred.Except(kvp.Value).Any();

                if (isAllContained)
                {
                    Console.WriteLine($"{kvp.Key} | #{string.Join(", #", kvp.Value)}");
                }
            }
        }
    }
}
