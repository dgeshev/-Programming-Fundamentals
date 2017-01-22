using System;

namespace _19.Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var allPics = int.Parse(Console.ReadLine());
            var filterTime = int.Parse(Console.ReadLine());
            var filterFactor = int.Parse(Console.ReadLine());
            var uploadTime = int.Parse(Console.ReadLine());

            var filtredPicsTime = allPics * filterTime;
            var goodPics =(int) Math.Ceiling((double)(allPics * filterFactor) / 100);
            var uploadDoneTime = (goodPics * uploadTime);
            // summary time in seconds = uploadDoneTime + filtredPicsTime
            TimeSpan time = TimeSpan.FromSeconds(uploadDoneTime + filtredPicsTime);
            string allTime = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(allTime);
        }
    }
}
