using System;
using YoutubeSnoop.Fluent;
using YoutubeSnoop;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Videos;
using YoutubeSnoop.Enums;

namespace IntegrationTests
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var v = Youtube.Video("H4imggTBb0Q").RequestPart(PartType.ContentDetails)
                                                .RequestPart(PartType.Statistics)
                                                .RequestPart(PartType.Status)
                                                .RequestPart(PartType.Localizations)
                                                .RequestPart(PartType.Player)
                                                .RequestPart(PartType.TopicDetails)
                                                .RequestPart(PartType.RecordingDetails)
                                                .RequestPart(PartType.LiveStreamingDetails);
            Console.WriteLine(v.ChannelTitle);
        }
    }
}