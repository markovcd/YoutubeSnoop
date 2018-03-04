using System;
using YoutubeSnoop.Entities.PlaylistItems;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
{
    public class YoutubePlaylistItem : IYoutubeItem
    {
        private IYoutubeItem _details;
        public IYoutubeItem Details => _details ?? (_details = Item.Snippet.ResourceId.GetYoutubeItem());

        public ResourceKind Kind { get; }
        public string Id { get; }
        public string Url { get; }
        public PlaylistItem Item { get; }
        public DateTime PublishedAt { get; }
        public string ChannelId { get; }
        public string Title { get; }
        public string Description { get; }
        public string ChannelTitle { get; }
        public string PlaylistId { get; }
        public int? Position { get; }

        public YoutubePlaylistItem(PlaylistItem playlistItem)
        {
            Item = playlistItem;
            if (Item == null) return;

            Kind = Item.Snippet.ResourceId.Kind;
            Id = Item.Snippet.ResourceId.GetId();
            PublishedAt = Item.Snippet.PublishedAt;
            ChannelId = Item.Snippet.ChannelId;
            Title = Item.Snippet.Title;
            Description = Item.Snippet.Description;
            ChannelTitle = Item.Snippet.ChannelTitle;
            PlaylistId = Item.Snippet.PlaylistId;
            Position = Item.Snippet.Position;

            Url = Extensions.GetUrl(Item.Kind, Item.Id);
        }
    }
}