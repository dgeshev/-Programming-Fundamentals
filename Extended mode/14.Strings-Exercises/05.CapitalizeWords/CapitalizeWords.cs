using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CapitalizeWords
{
    public class CapitalizeWords
    {
        public static void Main()
        {
            var inputText = Console.ReadLine().ToLower();

            var outputText = new List<string>();

            while (inputText != "end")
            {
                var tokens = inputText.Split(new[]
                { ' ', '.', ',', '!', '?', ':', ';', '(', ')', '"', '\t', '-' }, 
                StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                for (int i = 0; i < tokens.Count; i++)
                {
                    var currentWord = tokens[i].First().ToString().ToUpper() + string.Join("", tokens[i].Skip(1));
                    outputText.Add(currentWord);
                }

                Console.WriteLine(string.Join(", ", outputText));
                inputText = Console.ReadLine().ToLower();
                outputText.Clear();
            }
        }
    }
}
