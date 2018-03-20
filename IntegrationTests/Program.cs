using System;
using YoutubeSnoop.Fluent;
using YoutubeSnoop;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Videos;
using YoutubeSnoop.Enums;
using System.Linq;

namespace IntegrationTests
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var v = Youtube.Video("H4imggTBb0Q").RequestAllParts();
            Console.WriteLine(v.ChannelTitle);

            var c = Youtube.Channel().ForUsername("markovcd").RequestAllParts();
            Console.WriteLine(c.Title);

            var u = c.Uploads().ToList();
            var s = c.Subscriptions().RequestContentDetails().Take(20).ToList();
            var a = c.Activities().RequestContentDetails().Take(20).ToList();
        }
    }
}