using System;

namespace _03.Phonebook
{
    public class Program
    {
        public static void PrintElement(string[] phoneNumbers, string[] names, string inputName)
        {
            for (int i = 0; i < names.Length; i++)
            {

                if (names[i] == inputName)
                {
                    Console.WriteLine($"{names[i]} -> {phoneNumbers[i]}");
                }
            }
        }

        public static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');

            string inputName = Console.ReadLine();

            while (inputName != "done")
            {
                PrintElement(phoneNumbers, names, inputName);

                inputName = Console.ReadLine();
            }

        }
    }
}
