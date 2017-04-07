using System;
using System.Linq;

namespace _02.Stateless
{
    public class Stateless
    {
        public static void Main()
        {
            var state = Console.ReadLine();
            var fiction = Console.ReadLine();

            while (state != "collapse")
            {
                var tokens = state.Split(new[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                while (fiction.Length != 0)
                {
                    for (int i = 0; i < tokens.Count; i++)
                    {
                        if (tokens[i].Contains(fiction))
                        {
                            tokens[i] = tokens[i].Replace(fiction, string.Empty);
                        }
                    }

                    if (fiction.Length >= 2)
                    {
                        fiction = fiction.Substring(1, fiction.Length - 2);
                    }

                    else
                    {
                        fiction = fiction.Substring(1);
                    }
                }

                if (tokens.Count == 1 && tokens.Contains(""))
                {
                    Console.WriteLine("(void)");

                }
                else
                {
                    Console.WriteLine(string.Join(" ", tokens).Trim());
                }

                state = Console.ReadLine();

                if (state == "collapse")
                {
                    break;
                }

                fiction = Console.ReadLine();

            }
        }
    }
}
