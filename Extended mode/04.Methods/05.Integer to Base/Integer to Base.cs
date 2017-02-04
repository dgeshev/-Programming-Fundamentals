using System;

namespace _05.Integer_to_Base
{
    class Program
    {
        static string IntegerToBase(int number, int toBase)
        {
            var result = string.Empty;

            while (number > 0)
            {
                var reminder = number % toBase;
                result = reminder + result;
                number /= toBase;
            }
            return result;
        }

        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var toBase = int.Parse(Console.ReadLine());

            var converted = IntegerToBase(number, toBase);
            Console.WriteLine(converted);
        }
    }
}
