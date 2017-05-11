using System;
using System.Text.RegularExpressions;

namespace _04.HappinessIndex
{
    public class HappinessIndex
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var happyPattern =
                new Regex(@"[:][\)]|[:][D]|[;][\)]|[:][\*]|[:][\]]|[;][\]]|[:][}]|[;][}]|[\(][:]|[\*][:]|[c][:]|[\[][:]|[\[][;]");
            var sadPattern =
                new Regex(@"[:][\(]|[D][:]|[;][\(]|[:][\[]|[;][[]|[:][{]|[;][{]|[\)][:]|[:][c]|[\]][:]|[\]][;]");

            var isMatchHappyEmoji = happyPattern.IsMatch(input);
            var happyResult = happyPattern.Matches(input);
            double happyCount = 0;

            if (isMatchHappyEmoji)
            {
                happyCount = happyResult.Count;
            }

            var isMatchSadEmoj = sadPattern.IsMatch(input);
            var sadResult = sadPattern.Matches(input);
            double sadCount = 0;

            if (isMatchSadEmoj)
            {
                sadCount = sadResult.Count;
            }

            var resultCount = happyCount / sadCount;
            var emoji = string.Empty;

            if (resultCount >= 2)
            {
                emoji = ":D";
            }

            else if (resultCount > 1)
            {
                emoji = ":)";
            }

            else if (resultCount == 1)
            {
                emoji = ":|";
            }

            else if (resultCount < 1)
            {
                emoji = ":(";
            }

            Console.WriteLine($"Happiness index: {resultCount:f2} {emoji}");
            Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");
        }
    }
}
