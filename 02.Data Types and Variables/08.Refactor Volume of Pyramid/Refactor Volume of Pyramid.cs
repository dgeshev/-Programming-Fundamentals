using System;

namespace _08.Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {         
            Console.Write("Length: ");
            double leght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Heigth: ");
            double height = double.Parse(Console.ReadLine());
            var pyramidVolume = (leght + width + height) / 3;
            Console.WriteLine($"Pyramid Volume: {pyramidVolume}");

        }
    }
}
