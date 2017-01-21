using System;

namespace _06.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int i1 = 0; i1 < n; i1++)
                {
                    for (int i2 = 0; i2 < n; i2++)
                    {
                        char letter1 = (char)('a' + i);
                        char letter2 = (char)('a' + i1);
                        char letter3 = (char)('a' + i2);
                        Console.WriteLine("{0}{1}{2}", letter1, letter2, letter3);
                    }
                }
            }
        }
    }
}
