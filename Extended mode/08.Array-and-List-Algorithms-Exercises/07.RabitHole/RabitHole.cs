using System;
using System.Linq;

namespace _07.RabitHole
{
    public class RabitHole
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var energy = int.Parse(Console.ReadLine());
          
            string command;
            int steps;
            var i = 0;

            while(energy > 0)
            {
                var tokens = input[i].Split('|');
                if(tokens.Length == 1)
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    return;
                }
                command = tokens[0];
                steps = int.Parse(tokens[1]);

                switch (command)
                {
                    case "Left":
                        energy -= steps;
                        i -= steps;
                        if(i < 0)
                        {
                            i = 0;
                        }
                        break;
                    case "Right":
                        energy -= steps;
                        i += steps;
                        if (i >= input.Count())
                        {
                            i = 0;
                        }
                        break;
                    case "Bomb":
                        energy -= steps;
                        if (energy <= 0)
                        {
                            Console.WriteLine("You are dead due to bomb explosion!");
                            return;
                        }
                        input.RemoveAt(i);
                        i = 0;
                        break;
                }
            }

            if(energy <= 0)
            {
                Console.WriteLine("You are tired. You can't continue the mission.");
                return;
            }
        }
    }
}
