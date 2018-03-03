using System;
using YoutubeSnoop;
using YoutubeSnoop.Entities.Search;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Settings;

namespace IntegrationTests
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var videoId = "6vpOHq8bkzA";
            var channelId = "UCTxdujUsyc9TsjW1BnBxivg";
            var playlistId = "PLg-NWZjrm22usa_eVDKCADwbJ29JYOrDI";

            var video = new YoutubeVideo(videoId);
            var channel = new YoutubeChannel(channelId);
            var playlist = new YoutubePlaylist(playlistId);
        }
    }
}