using System;
using System.Linq;

namespace _01.PlaceHoders
{
    public class PlaceHoders
    {
        public static void Main()
        {
            var inputText = Console.ReadLine();

            while (inputText != "end")
            {
                var tokens = inputText.Split(new[] { '-', '>' },
                    StringSplitOptions.RemoveEmptyEntries);

                var firstPart = tokens[0].Trim();

                var secondPart = tokens[1].Split(new[] { ' ', ',' },
                    StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int i = 0; i < secondPart.Count; i++)
                {
                    var placeHol = "{" + i + "}";

                    firstPart = firstPart.Replace(placeHol, secondPart[i]);
                }

                Console.WriteLine(firstPart);

                inputText = Console.ReadLine();
            }
        }
    }
}
