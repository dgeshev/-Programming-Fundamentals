using System;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());

            double hoursToSeconds = hours * 3600;
            double minutesToSeconds = minutes * 60;

            Console.WriteLine("{0:f6}",(distance / (hoursToSeconds + minutesToSeconds + seconds)));
            Console.WriteLine("{0:f6}", (distance / (hoursToSeconds + minutesToSeconds + seconds)) * 3.6);
            Console.WriteLine("{0:f6}", (distance / (hoursToSeconds + minutesToSeconds + seconds)) * 2.23693629);
        }
    }
}
