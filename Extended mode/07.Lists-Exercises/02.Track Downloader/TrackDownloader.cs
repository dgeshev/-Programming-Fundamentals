using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Track_Downloader
{
    public class TrackDownloader
    {
        public static void Main()
        {
            var blackList = Console.ReadLine().Split(' ').ToList();
            var songList = new List<string>();
            var track = Console.ReadLine();
           

            while (track != "end")
            {
                bool blackListMatch = false;
                for (int i = 0; i < blackList.Count; i++)
                {
                    if (track.Contains(blackList[i]))
                    {
                        blackListMatch = true;
                    }
                }

                if (blackListMatch != true)
                {
                    songList.Add(track);
                }

                track = Console.ReadLine();
            }

            songList.Sort();

            foreach (var song in songList)
            {
                Console.WriteLine(song);
            }
        }
    }
}
