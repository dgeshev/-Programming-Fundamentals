using System;

namespace _03.String_Repeater
{
    public class Program
    {
        public static string RepeatString(int count, string word)
        {
            string repeatedString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                repeatedString += word;
            }

            return repeatedString;
        }

        public static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());        

            Console.WriteLine(RepeatString(count, word));
        }
    }
}
