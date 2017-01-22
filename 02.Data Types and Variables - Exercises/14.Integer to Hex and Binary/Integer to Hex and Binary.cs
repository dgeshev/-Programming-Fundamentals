using System;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber = int.Parse(Console.ReadLine());
            string hexaDecimal = decimalNumber.ToString("X");
            string binary = Convert.ToString(decimalNumber, 2);

            Console.WriteLine(hexaDecimal);
            Console.WriteLine(binary);
        }
    }
}
