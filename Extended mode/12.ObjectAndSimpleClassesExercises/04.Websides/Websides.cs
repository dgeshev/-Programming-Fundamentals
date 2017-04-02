using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Websides
{
    public class Web
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Queries { get; set; }
    }

    public class Websides
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var resultList = new List<Web>();

            while (input != "end")
            {
                var tokens = input.Split(new[] { ' ', '|', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                var host = tokens[0];
                var domain = tokens[1];
                var queries = tokens.Skip(2).ToList();

                var result = new Web();
                result.Host = host;
                result.Domain = domain;
                result.Queries = queries;

                resultList.Add(result);
                input = Console.ReadLine();
            }

            foreach (var kvp in resultList)
            {
                if (kvp.Queries.Count != 0)
                {
                    Console.Write($"https://www.{kvp.Host}.{kvp.Domain}/query?=");

                    for (int i = 0; i < kvp.Queries.Count - 1; i++)
                    {
                        Console.Write($"[{string.Join("", kvp.Queries[i])}]&");
                    }

                    for (int i = kvp.Queries.Count - 1; i < kvp.Queries.Count; i++)
                    {
                        Console.Write($"[{kvp.Queries[i]}]");
                    }           
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"https://www.{kvp.Host}.{kvp.Domain}");
                }
            }
        }
    }
}
