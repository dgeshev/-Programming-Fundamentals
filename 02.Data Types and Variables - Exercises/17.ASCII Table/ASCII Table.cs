using System;


namespace _17.ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            for (int i = beginNumber; i <= endNumber; i++)
            {
                char converted = Convert.ToChar(i);
                Console.Write("{0} ", converted);                
            }
            Console.WriteLine();
        }
    }
}
