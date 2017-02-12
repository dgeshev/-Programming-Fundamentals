using System;

namespace _07.Count_of_Capital_Letters
{
    public class Program
    {
        public static void Main()
        {
            string[] text = Console.ReadLine().Split(' ');
            var count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                string currentText = text[i];

                if (currentText.Length == 1)
                {
                    char cuerrentLetter = currentText[0];
                    if (cuerrentLetter >= 'A' && cuerrentLetter <= 'Z')
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
