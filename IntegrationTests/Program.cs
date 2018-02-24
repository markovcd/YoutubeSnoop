using System;
using System.Linq;
using YoutubeSnoop;

namespace IntegrationTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = new YoutubeVideo("6vpOHq8bkzA");
            var p = new YoutubePlaylist("PLg-NWZjrm22sznjdUEeNYSbA-Bt24f4SW").ToList();
        }
    }
}
