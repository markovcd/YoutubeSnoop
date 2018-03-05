using System.Linq;
using YoutubeSnoop;
using YoutubeSnoop.Entities.Videos;
using YoutubeSnoop.Settings;

namespace IntegrationTests
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var l = Youtube.Languages("pl").ToList();
            var c = Youtube.Countries().ToList();
            
        }
    }
}