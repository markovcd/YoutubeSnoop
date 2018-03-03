using YoutubeSnoop.Entities.PlaylistItems;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
{
    public class YoutubePlaylistItem : IYoutubeItem
    {
        public ResourceKind Kind { get; }
        public string Id { get; }
        public PlaylistItem Response { get; }

        private IYoutubeItem _details;
        public IYoutubeItem Details => _details ?? (_details = Response.Snippet.ResourceId.GetYoutubeItem());

        internal YoutubePlaylistItem(PlaylistItem playlistItem)
        {
            Response = playlistItem;
            Kind = playlistItem.Snippet.ResourceId.Kind;
            Id = playlistItem.Snippet.ResourceId.GetId();
        }

        
    }
}