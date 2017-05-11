using System;
using System.Text.RegularExpressions;

namespace _02.FishStatistics
{
    public class FishStatistics
    {
        public static void Main()
        {
            var inputFishes = Console.ReadLine();

            var pattern = @"(?:(>+)|)<(\(+)('|-|x)>";

            var regEx = new Regex(pattern);

            var resultFishes = regEx.Matches(inputFishes);

            var count = 1;

            if (!regEx.IsMatch(inputFishes))
            {
                Console.WriteLine("No fish found.");
            }

            foreach (Match fish in resultFishes)
            {
                if (fish.Groups[2].Length > 10)
                {
                    Console.WriteLine($"Fish {count}: {fish.Value}");

                    if (fish.Groups[1].Length > 5)
                    {
                        Console.WriteLine($"  Tail type: Long ({fish.Groups[1].Length * 2} cm)");
                    }

                    else if (fish.Groups[1].Length > 1)
                    {
                        Console.WriteLine($"  Tail type: Medium ({fish.Groups[1].Length * 2} cm)");
                    }

                    else if (fish.Groups[1].Length == 1)
                    {
                        Console.WriteLine($"  Tail type: Short ({fish.Groups[1].Length * 2} cm)");
                    }

                    else
                    {
                        Console.WriteLine($"  Tail type: None");
                    }

                    Console.WriteLine($"  Body type: Long ({fish.Groups[2].Length * 2} cm)");

                    if (fish.Groups[3].Value == "'")
                    {
                        Console.WriteLine("  Status: Awake");
                    }

                    else if (fish.Groups[3].Value == "-")
                    {
                        Console.WriteLine("  Status: Asleep");
                    }

                    else if (fish.Groups[3].Value == "x")
                    {
                        Console.WriteLine("  Status: Dead");
                    }

                    count++;
                }             

                else if (fish.Groups[2].Length > 5)
                {
                    Console.WriteLine($"Fish {count}: {fish.Value}");

                    if (fish.Groups[1].Length > 5)
                    {
                        Console.WriteLine($"  Tail type: Long ({fish.Groups[1].Length * 2} cm)");
                    }

                    else if (fish.Groups[1].Length > 1)
                    {
                        Console.WriteLine($"  Tail type: Medium ({fish.Groups[1].Length * 2} cm)");
                    }

                    else if (fish.Groups[1].Length == 1)
                    {
                        Console.WriteLine($"  Tail type: Short ({fish.Groups[1].Length * 2} cm)");
                    }

                    else
                    {
                        Console.WriteLine($"  Tail type: None");
                    }

                    Console.WriteLine($"  Body type: Medium ({fish.Groups[2].Length * 2} cm)");

                    if (fish.Groups[3].Value == "'")
                    {
                        Console.WriteLine("  Status: Awake");
                    }

                    else if (fish.Groups[3].Value == "-")
                    {
                        Console.WriteLine("  Status: Asleep");
                    }

                    else if (fish.Groups[3].Value == "x")
                    {
                        Console.WriteLine("  Status: Dead");
                    }

                    count++;
                }

                else
                {
                    Console.WriteLine($"Fish {count}: {fish.Value}");

                    if (fish.Groups[1].Length > 5)
                    {
                        Console.WriteLine($"  Tail type: Long ({fish.Groups[1].Length * 2} cm)");
                    }

                    else if (fish.Groups[1].Length > 1)
                    {
                        Console.WriteLine($"  Tail type: Medium ({fish.Groups[1].Length * 2} cm)");
                    }

                    else if (fish.Groups[1].Length == 1)
                    {
                        Console.WriteLine($"  Tail type: Short ({fish.Groups[1].Length * 2} cm)");
                    }

                    else
                    {
                        Console.WriteLine($"  Tail type: None");
                    }

                    Console.WriteLine($"  Body type: Short ({fish.Groups[2].Length * 2} cm)");

                    if (fish.Groups[3].Value == "'")
                    {
                        Console.WriteLine("  Status: Awake");
                    }

                    else if (fish.Groups[3].Value == "-")
                    {
                        Console.WriteLine("  Status: Asleep");
                    }

                    else if (fish.Groups[3].Value == "x")
                    {
                        Console.WriteLine("  Status: Dead");
                    }
                    count++;
                }
            }
        }
    }
}
