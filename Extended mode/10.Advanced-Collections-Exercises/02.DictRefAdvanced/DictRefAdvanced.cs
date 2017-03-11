using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.DictRefAdvanced
{
    public class DictRefAdvanced
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var resultDict = new Dictionary<string, List<int>>();

            while (input != "end")
            {
                var tokens = input.Split(' ', ',');
                var name = tokens[0];
                var lastElement = tokens[tokens.Length - 1];
                int num = 0;

                if (int.TryParse(lastElement, out num))
                {
                    if (!resultDict.ContainsKey(name))
                    {
                        resultDict[name] = new List<int>();
                    }

                    for (int i = 2; i < tokens.Length; i+= 2 )
                    {
                        resultDict[name].Add(int.Parse(tokens[i]));
                    }
                }
                else
                {
                    if (resultDict.ContainsKey(lastElement))
                    {
                        var referenced = new List<int>(resultDict[lastElement]);
                        resultDict[name] = referenced;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in resultDict)
            {
                Console.WriteLine($"{kvp.Key} === {string.Join(", ", kvp.Value)}");
            }
        }
    }
}
