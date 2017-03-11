using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Shellbound
{
    public class Shellbound
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var resultDict = new Dictionary<string, HashSet<int>>();

            while (input != "Aggregate")
            {
                var tokens = input.Split(' ');
                var region = tokens[0];

                var shellSize = int.Parse(tokens[1]);

                if (!resultDict.ContainsKey(region))
                {
                    resultDict[region] = new HashSet<int>();
                }

                resultDict[region].Add(shellSize);
                input = Console.ReadLine();
            }

            foreach (var kvp in resultDict)
            {
                var regions = kvp.Key;
                var shells = kvp.Value;
                var average = shells.Sum() - (shells.Sum() / shells.Count());

                Console.WriteLine($"{regions} -> {string.Join(", ", shells)} ({average})");

            }
        }
    }
}
