﻿using System;
using System.Linq;

namespace _05.Char_Rotation
{
    public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var result = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result += (char)(text[i] - numbers[i]);
                }

                else
                {
                    result += (char)(text[i] + numbers[i]);
                }
            }
            Console.WriteLine(result);
        }
    }
}
