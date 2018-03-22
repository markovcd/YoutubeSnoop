using System;
using YoutubeSnoop.Fluent;
using YoutubeSnoop;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Api.Entities.Videos;
using YoutubeSnoop.Enums;
using System.Linq;
using YoutubeSnoop.Api.Entities.Search;

namespace IntegrationTests
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //var v = Youtube.Video("H4imggTBb0Q").RequestAllParts();
            //Console.WriteLine(v.ChannelTitle);

            //var com = v.Comments().RequestAllParts().Take(20).ToList();

            //var c = Youtube.Channel().ForUsername("markovcd").RequestAllParts();
            //Console.WriteLine(c.Title);

            //var u = c.Uploads().ToList();
            //var s = c.Subscriptions().RequestContentDetails().Take(20).ToList();
            //var a = c.Activities().RequestContentDetails().Take(20).ToList();

            //var su = Youtube.Subscriptions(new YoutubeSnoop.Api.Settings.SubscriptionApiRequestSettings { ChannelId = c.Id }).RequestAllParts().Take(10).ToList();


            //var cat = Youtube.VideoCategories().ForCountry("pl").Take(20).ToList();

            //var chan = cat.First().Channel();
            //var vids = chan.Uploads().Take(10).ToList();
            //var vid = vids.First().Details<YoutubeVideo>();
            //Console.WriteLine(vid.Title);

            //var popular = Youtube.Videos().MostPopular().Take(2).ToList();
            var settings = new SearchApiRequestSettings { Query = "minecraft" };
            var downloader = new JsonDownloader();
            var deserializer = new PagedResponseDeserializer<SearchResult>();
            var urlFormatter = new ApiUrlFormatter();

            var request = ApiRequest.Create(settings, null, 20, downloader, deserializer, urlFormatter);
            var first = request.FirstItem;
        }
    }
}