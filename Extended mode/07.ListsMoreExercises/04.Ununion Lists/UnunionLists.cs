using System;
using System.Linq;

namespace _04.Ununion_Lists
{
  public  class UnunionLists
    {
       public static void Main()
        {
            var primal = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var countOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfLines; i++)
            {
                var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                foreach (var number in list)
                {
                    if (primal.Contains(number))
                    {
                        primal.Remove(number);
                    }

                    else
                    {
                        primal.Add(number);
                    }
                }   
            }

            primal.Sort();

            Console.WriteLine(string.Join(" ", primal));

        }
    }
}
