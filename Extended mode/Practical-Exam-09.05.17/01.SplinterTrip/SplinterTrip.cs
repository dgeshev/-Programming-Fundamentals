using System;

namespace _01.SplinterTrip
{
    public class SplinterTrip
    {
        public static void Main()
        {
            var tripDistance = double.Parse(Console.ReadLine());
            var fuelCalacity = double.Parse(Console.ReadLine());
            var heavyWindsMiles = double.Parse(Console.ReadLine());

            var milesInNonHeavyWinds = tripDistance - heavyWindsMiles;
            var nonHeavyWindsConsumption = milesInNonHeavyWinds * 25;
            var heavyWindsConsumption = heavyWindsMiles * (25 * 1.5);
            var fuelConsumption = nonHeavyWindsConsumption + heavyWindsConsumption;
            var tolerance = fuelConsumption * 0.05;
            var totalFuelConsumption = fuelConsumption + tolerance;
            var reminingFuel = fuelCalacity - totalFuelConsumption;

            Console.WriteLine($"Fuel needed: {totalFuelConsumption:f2}L");

            if (reminingFuel >= 0)
            {
                Console.WriteLine($"Enough with {reminingFuel:f2}L to spare!");
            }

            else
            {
                Console.WriteLine($"We need {Math.Abs(reminingFuel):f2}L more fuel.");
            }
        }
    }
}
