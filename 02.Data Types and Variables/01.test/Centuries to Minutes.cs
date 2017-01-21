using System;

namespace _01.test
{
    class test
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Centuries: ");
            int centuries = int.Parse(Console.ReadLine());
            int year = centuries * 100;
            int days = (int)(year * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", centuries, year, days, hours, minutes);
        }
    }
}
