using System;
using System.Collections.Generic;

namespace _05.UserLogins
{
    public class UserLogins
    {
        public static void Main()
        {
            var resultDict = new Dictionary<string, string>();
            var input = Console.ReadLine();
            var count = 0;

            while (input != "login")
            {
                var token = input.Trim().Split();
                var userame = token[0];
                var validPass = token[token.Length - 1];

                if (!resultDict.ContainsKey(userame))
                {
                    resultDict[userame] = validPass;
                }


                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "end")
            {
                var token = input.Trim().Split();
                var userame = token[0];
                var validPass = token[token.Length - 1];

                if (!resultDict.ContainsKey(userame))
                {
                    Console.WriteLine($"{userame}: login failed");
                    count++;
                }

                if (resultDict.ContainsKey(userame) && !resultDict.ContainsValue(validPass))
                {
                    Console.WriteLine($"{userame}: login failed");
                    count++;
                }

                else if (resultDict.ContainsKey(userame) && resultDict.ContainsValue(validPass))
                {
                    Console.WriteLine($"{userame}: logged in successfully");
                }

                input = Console.ReadLine();

            }

            if (input == "end")
            {
                Console.WriteLine($"unsuccessful login attempts: {count}");              
            }

        }
    }
}
