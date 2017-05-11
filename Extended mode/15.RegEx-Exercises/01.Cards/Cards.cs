using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Cards
{
    public class Cards
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var regex = new Regex(@"([1]?[0-9JQKA])([SHDC])");

            var result = regex.Matches(input);

            var validCards = new List<string>();

            foreach (Match card in result)
            {
                var checkInt = 0;

                if (int.TryParse(card.Groups[1].Value, out checkInt))
                {
                    if (checkInt < 2 || checkInt > 10)
                    {
                        continue;
                    }
                }

                validCards.Add(card.Value);
            }

            Console.WriteLine(string.Join(", ", validCards));
        }
    }
}
