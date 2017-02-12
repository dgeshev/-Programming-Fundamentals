using System;

namespace _08.Array_Symmetry
{
    public class Program
    {
        public static void Main()
        {
            string[] text = Console.ReadLine().Split(' ');
            bool isSymmetry = false;

            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[0] == text[text.Length - i - 1])
                {
                    isSymmetry = true;
                    break;
                }
            }

            if (isSymmetry)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
