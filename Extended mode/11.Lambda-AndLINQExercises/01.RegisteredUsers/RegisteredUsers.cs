using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _01.RegisteredUsers
{
    public class RegisteredUsers
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var inputToDict = new Dictionary<string, DateTime>();

            while (input != "end")
            {
                var tokens = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var name = tokens[0];
                var dateTime = DateTime.ParseExact(tokens[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (!inputToDict.ContainsKey(name))
                {
                    inputToDict[name] = dateTime;
                }

                input = Console.ReadLine();
            }

                var resultDict = inputToDict.Reverse()
                    .OrderBy(x => x.Value)
                    .Take(5)
                    .OrderByDescending(x => x.Value)
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var kvp in resultDict)
                {
                    Console.WriteLine($"{kvp.Key}");
                }

        }
    }
}
