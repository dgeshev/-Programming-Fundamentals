using System;


namespace _04.Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string trueOne = "True";
            string falseOne = "False";

            if (word == trueOne)
            {
                Console.WriteLine("Yes");
            }
            else if (word == falseOne)
            {
                Console.WriteLine("No");
            }
        }
    }
}
