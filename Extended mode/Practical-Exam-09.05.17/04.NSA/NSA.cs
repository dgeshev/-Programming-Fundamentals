using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.NSA
{
    public class NSA
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var resultDict = new Dictionary<string, Dictionary<string, int>>();

            while (input != "quit")
            {
                var tokens = input.Split(new[] { ' ', '-', '>' }, 
                    StringSplitOptions.RemoveEmptyEntries).ToList();

                var country = tokens[0];
                var name = tokens[1];
                var daysInService = int.Parse(tokens[2]);

                if (!resultDict.ContainsKey(country))
                {
                    resultDict[country] = new Dictionary<string, int>();
                }
                resultDict[country][name] = +daysInService;

                input = Console.ReadLine();
            }

            foreach (var coutry in resultDict.OrderByDescending(x => x.Value.Keys.Count))
            {
                Console.WriteLine($"Country: {coutry.Key}");

                foreach (var kvp in coutry.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"**{kvp.Key} : {kvp.Value}");
                }
            }
        }
    }
}
