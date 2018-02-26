using System.Linq;
using YoutubeSnoop;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Settings;

namespace IntegrationTests
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var settings = new VideoApiRequestSettings
            {
                Id = "j_qWBhhQNzg"
            };

            var parts = new[]
            {
                PartType.ContentDetails, PartType.Snippet, PartType.Statistics, PartType.Status, PartType.Localizations 
            };

            var api = ApiRequest.Create(settings, parts);

            var l =  api.TotalItems.ToList();
        }
    }
}