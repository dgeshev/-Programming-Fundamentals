using System;

namespace _01.Hello__Name
{
    public class Program
    {
        public static string Name(string name)
        {
            Console.Write(name);
            return name;
        }

        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.Write("Hello, ");
            Name(name);
            Console.WriteLine('!');
        }
    }
}
