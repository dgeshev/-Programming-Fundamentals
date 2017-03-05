using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.DecodeRadioFrequencies
{
    public class DecodeRadioFrequencies
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            var numToWords = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                string[] freaquences = new string[2];
                freaquences = input[i].Split('.');
                var leftPart = int.Parse(freaquences[0]);
                var rightPart = int.Parse(freaquences[1]);
                var leftToASCII = Convert.ToChar(leftPart);
                var rightToASCII = Convert.ToChar(rightPart);

                if (leftPart != 0)
                {
                    numToWords.Insert(i, leftToASCII);
                }
                if (rightPart != 0)
                {
                    numToWords.Insert(numToWords.Count - i, rightToASCII);
                }
            }
            Console.WriteLine(string.Join("", numToWords));   
        }
    }
}
