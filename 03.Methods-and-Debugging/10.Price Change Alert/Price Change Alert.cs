using System;

 public class PriceChangeAlert
{
    public static void Main()
    {
        int numberOfStockPrices = int.Parse(Console.ReadLine());
        double border = double.Parse(Console.ReadLine());
        double last = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfStockPrices - 1; i++)
        {
            double c = double.Parse(Console.ReadLine());
            double div = Percent(last, c);
            bool isSignificantDifference = AnyDifference(div, border);
            string message = Get(c, last, div, isSignificantDifference);

            Console.WriteLine(message);
            last = c;
        }
    }

    public static string Get(double c, double last, double difference, bool etherTrueOrFalse)
    {
        string to = string.Empty;

        if (difference == 0)
        {
            to = string.Format("NO CHANGE: {0}", c);
        }
        else if (!etherTrueOrFalse)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, c, difference);
        }
        else if (etherTrueOrFalse && (difference > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, c, difference);
        }
        else if (etherTrueOrFalse && (difference < 0))
        {
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, c, difference);
        }      
             
        return to;
    }

    public static bool AnyDifference(double border, double isDiff)
    {
        if (Math.Abs(border) >= isDiff)
        {
            return true;
        }
        else
        {
            return false;
        }       
    }

    public static double Percent(double l, double c)
    {
        double r = (c - l) / l;
        return r;
    }
}
