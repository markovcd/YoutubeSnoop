using System;
using YoutubeSnoop.Entities.Channels;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubeChannel : IYoutubeItem
    {
        public ApiRequestSingle<Channel, ChannelApiRequestSettings> Request { get; }

        public string Url { get; }
        public string Id { get; }
        public string Title { get; }
        public string Description { get; }
        public string CustomUrl { get; }
        public DateTime PublishedAt { get; }

        public YoutubePlaylistItems Uploads { get; }
        public YoutubePlaylists Playlists { get; }

        public YoutubeChannel(string id)
            : this(new ChannelApiRequestSettings { Id = id }) { }

        public YoutubeChannel(ChannelApiRequestSettings settings) 
        {
            Request = new ApiRequestSingle<Channel, ChannelApiRequestSettings>(settings, new[] { PartType.Snippet, PartType.ContentDetails, PartType.Status });
            if (Request.Item == null) return;

            Id = Request.Item.Id;          
            Title = Request.Item.Snippet.Title;
            Description = Request.Item.Snippet.Description;
            CustomUrl = Request.Item.Snippet.CustomUrl;
            PublishedAt = Request.Item.Snippet.PublishedAt;

            Uploads = new YoutubePlaylistItems(Request.Item.ContentDetails.RelatedPlaylists.Uploads);
            Playlists = new YoutubePlaylists(Request.Item.Id);
            Url = Extensions.GetUrl(Request.Item.Kind, Request.Item.Id);
        }

        public YoutubeChannel(Channel channel)
        {         
            Id = channel.Id;
            Title = channel.Snippet.Title;
            Description = channel.Snippet.Description;
            CustomUrl = channel.Snippet.CustomUrl;
            PublishedAt = channel.Snippet.PublishedAt;

            Url = Extensions.GetUrl(channel.Kind, channel.Id);
        }
    }
}