using System;

namespace _09.Altitude
{
    public class Altitude
    {
        public static void Main()
        {
            string[] commands = Console.ReadLine().Split(' ');
            double up = 0;
            double down = 0;
            double initialAltitude = Int32.Parse(commands[0]);

            for (int i = 1; i < commands.Length; i++)
            {
                if (commands[i] == "up")
                {
                    up += Int32.Parse(commands[i + 1]);
                }
                else if (commands[i] == "down")
                {
                    down += Int32.Parse(commands[i + 1]);
                }
            }
            if (initialAltitude + up - down > 0)
            {
                Console.WriteLine($"got through safely. current altitude: {initialAltitude + up - down}m");
            }
            else
            {
                Console.WriteLine("crashed");
            }
        }
    }
}
