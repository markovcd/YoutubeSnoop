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
            var vid = Youtube.Video("IK6wJUNirbs");
            var rel = vid.Related().Take(20).ToList();
            //var api = Youtube.DefaultRequest<Video, VideoApiRequestSettings>(new VideoApiRequestSettings { Id = "IK6wJUNirbs" }, null).ToList();
            
        }
    }
}