using System;
using System.Linq;
using YoutubeSnoop.Entities.Channels;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubeChannel : IYoutubeItem
    {
        public IApiRequest<Channel> Request { get; }
        public Channel Item { get; }

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
            Request = new ApiRequest<Channel, ChannelApiRequestSettings>(settings, new[] { PartType.Snippet, PartType.ContentDetails, PartType.Status });
            Item = Request.Items.FirstOrDefault();
            if (Item == null) return;


            Id = Item.Id;          
            Title = Item.Snippet.Title;
            Description = Item.Snippet.Description;
            CustomUrl = Item.Snippet.CustomUrl;
            PublishedAt = Item.Snippet.PublishedAt;

            Uploads = new YoutubePlaylistItems(Item.ContentDetails.RelatedPlaylists.Uploads);
            Playlists = new YoutubePlaylists(Item.Id);
            Url = Extensions.GetUrl(Item.Kind, Item.Id);
        }

        public YoutubeChannel(Channel channel)
        {
            Item = channel;
            if (Item == null) return;

            Id = Item.Id;
            Title = Item.Snippet.Title;
            Description = Item.Snippet.Description;
            CustomUrl = Item.Snippet.CustomUrl;
            PublishedAt = Item.Snippet.PublishedAt;

            Uploads = new YoutubePlaylistItems(Item.ContentDetails.RelatedPlaylists.Uploads);
            Playlists = new YoutubePlaylists(Item.Id);
            Url = Extensions.GetUrl(Item.Kind, Item.Id);
        }
    }
}