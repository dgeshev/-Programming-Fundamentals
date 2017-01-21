using System;

namespace _04.Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            var people = int.Parse(Console.ReadLine());
            var capacity = int.Parse(Console.ReadLine());
            var coursese = (int)Math.Ceiling((double)people / capacity);

            Console.WriteLine(coursese);

        }
    }
}
