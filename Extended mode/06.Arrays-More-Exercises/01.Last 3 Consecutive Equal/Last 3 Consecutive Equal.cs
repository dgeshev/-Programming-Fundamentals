using System;

namespace _01.Last_3_Consecutive_Equal
{
    public class Program
    {
        public static void Main()
        {
            string[] text = Console.ReadLine().Split(' ');

            for (int i = text.Length - 1; i > 1; i--)
            {
                if (text[i] == text[i - 1] && text[i - 1] == text[i - 2])
                {
                    Console.WriteLine($"{text[i]} {text[i]} {text[i]}");
                    break;                 
                }   
            }
                 
        }
    }
}
