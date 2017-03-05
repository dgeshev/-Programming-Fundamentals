using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Batteries
{
    public class Batteries
    {
        public static void Main()
        {
            var capacities = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var usagePerHour = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var amountHours = int.Parse(Console.ReadLine());
            var calculatedUsage = new List<double>();

            for (int i = 0; i < usagePerHour.Count; i++)
            {
                calculatedUsage.Add(usagePerHour[i] * amountHours);
            }

            for (int i = 0; i < capacities.Count; i++)
            {
                var result = capacities[i] - calculatedUsage[i];
                var percent = (result / capacities[i]) * 100;

                if (result > 0)
                {
                    Console.WriteLine($"Battery {i + 1}: {result:f2} mAh ({percent:f2})%");
                }

                else
                {

                    Console.WriteLine($"Battery {i + 1}: dead (lasted {(int) Math.Ceiling(capacities[i] / usagePerHour[i])} hours)");
                }
            }

        }
    }
}
