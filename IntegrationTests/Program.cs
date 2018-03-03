using System;
using System.Linq;
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
            var query = "jestem hardkorem";

            var video = new YoutubeVideo(videoId);
            
            var channel = new YoutubeChannel(channelId);

            var playlist = new YoutubePlaylist(playlistId);
            var playlistItems = playlist.Items;
            var playlistItemDetails = playlistItems.Items.FirstOrDefault().Details;

            var search = new YoutubeSearch(query);
            var searchDetails = search.Items.FirstOrDefault().Details;
        }
    }
}