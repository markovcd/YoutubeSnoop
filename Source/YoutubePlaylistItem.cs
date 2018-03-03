using System;
using YoutubeSnoop.Entities.PlaylistItems;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
{
    public class YoutubePlaylistItem : IYoutubeItem
    {
        private IYoutubeItem _details;
        public IYoutubeItem Details => _details ?? (_details = Response.Snippet.ResourceId.GetYoutubeItem());

        public ResourceKind Kind { get; }
        public string Id { get; }
        public PlaylistItem Response { get; }
        public DateTime PublishedAt { get; }
        public string ChannelId { get; }
        public string Title { get; }
        public string Description { get; }
        public string ChannelTitle { get; }
        public string PlaylistId { get; }
        public int? Position { get; }       

        internal YoutubePlaylistItem(PlaylistItem playlistItem)
        {
            Response = playlistItem;
            Kind = playlistItem.Snippet.ResourceId.Kind;
            Id = playlistItem.Snippet.ResourceId.GetId();
            PublishedAt = playlistItem.Snippet.PublishedAt;
            ChannelId = playlistItem.Snippet.ChannelId;
            Title = playlistItem.Snippet.Title;
            Description = playlistItem.Snippet.Description;
            ChannelTitle = playlistItem.Snippet.ChannelTitle;
            PlaylistId = playlistItem.Snippet.PlaylistId;
            Position = playlistItem.Snippet.Position;
        }
    }
}