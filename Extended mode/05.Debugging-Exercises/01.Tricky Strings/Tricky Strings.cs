using System;

public class TrickyStrings
{
    public static void Main(string[] args)
    {
        var delimiter = Console.ReadLine();
        var numberOfStrings = int.Parse(Console.ReadLine());
        var result = string.Empty;
        var currentString = string.Empty;

        for (int i = 0; i < numberOfStrings; i++)
        {
            currentString += Console.ReadLine();
            currentString += delimiter;
        }
        result = currentString.Remove(currentString.Length - 1);
        Console.WriteLine(result);
    }
}