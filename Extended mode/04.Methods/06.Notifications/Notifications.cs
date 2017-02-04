using System;

namespace _06.Notifications
{
    public class Notifications
    {
        static string ShowSuccess(string operation, string message)
        {
            string output = ($"Successfully executed {operation}.\n==============================\nMessage: {message}.");
            return output;
        }

        static string ShowError(string operation, int code)
        {
            string output = ($"Error: Failed to execute {operation}.\n==============================\nError Code: {code}.");
            return output;
        }

        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string successOrError = Console.ReadLine();

                if (successOrError.Equals("success"))
                {
                    string opetarion = Console.ReadLine();
                    string message = Console.ReadLine();

                    Console.WriteLine(ShowSuccess(opetarion, message));
                }

                else if (successOrError.Equals("error"))
                {
                    if (n >= 0)
                    {
                        string opetarion = Console.ReadLine();
                        int code = int.Parse(Console.ReadLine());

                        Console.WriteLine(ShowError(opetarion, code));
                        Console.WriteLine("Reason: Invalid Client Data");
                    }

                    else
                    {
                        string opetarion = Console.ReadLine();
                        int code = int.Parse(Console.ReadLine());

                        Console.WriteLine(ShowError(opetarion, code));
                        Console.WriteLine("Reason: Internal System Failure");
                    }
                }

            }
        }
    }
}
