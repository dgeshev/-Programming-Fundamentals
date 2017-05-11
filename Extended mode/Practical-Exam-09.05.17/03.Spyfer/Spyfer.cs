using System;
using System.Linq;

namespace _03.Spyfer
{
    public class Spyfer
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();


            for (int i = 0; i < input.Count; i++)
            {
                if (i == input.Count - 1)
                {
                    if (input[i] == input[input.Count - 2] && input.Count > 1)
                    {
                        input.RemoveAt(i - 1);
                        break;
                    }

                    break;
                }

                if (i == 0 && input[i] == input[i + 1])
                {
                    input.RemoveAt(i + 1);

                    if (input.Count == 1)
                    {
                        break;
                    }
                    i = -1;
                }
                

                if (i > 0 && input[i] == (input[i - 1] + input[i + 1]))
                {
                    input.RemoveAt(i - 1);
                    input.RemoveAt(i);

                    if (input.Count == 1)
                    {
                        break;
                    }

                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
