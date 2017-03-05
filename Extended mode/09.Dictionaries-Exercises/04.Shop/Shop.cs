using System;
using System.Collections.Generic;

namespace _04.Shop
{
    public class Shop
    {
        public static void Main()
        {
            var resultDict = new Dictionary<string, int>();
            var input = Console.ReadLine();

            while (input != "shopping time")
            {
                var token = input.Trim().Split();
                var product = token[1];
                var quantity = int.Parse(token[2]);

                if (!resultDict.ContainsKey(product))
                {
                    resultDict[product] = quantity;
                }

                else
                {
                    resultDict[product] += quantity;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "exam time")
            {              
                var token = input.Trim().Split();
                var product = token[1];
                var quantity = int.Parse(token[2]);

                if (!resultDict.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }

                else
                {
                    if (resultDict[product] == 0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }

                    else
                    {
                        resultDict[product] -= quantity;
                        if (resultDict[product] < 0)
                        {
                            resultDict[product] = 0;
                        }
                    }
                }

                input = Console.ReadLine();
            }


            foreach (var kvp in resultDict)
            {
                if (kvp.Value > 0)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
             
            }
        }
    }
}
