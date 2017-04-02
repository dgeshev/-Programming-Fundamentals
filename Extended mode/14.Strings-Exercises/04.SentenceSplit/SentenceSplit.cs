using System;

namespace _04.SentenceSplit
{
    public class SentenceSplit
    {
        public static void Main()
        {
            var sentence = Console.ReadLine();
            var delimiter = Console.ReadLine();
            var resultDelimit = new string[] {delimiter};

            var result = sentence.Split(resultDelimit, StringSplitOptions.None);

            Console.WriteLine($"[{string.Join(", ", result)}]");

        }
    }
}
