using YoutubeSnoop.Entities.PlaylistItems;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubePlaylistItem : IYoutubeItem<Snippet>
    {
        public Snippet Snippet { get; }

        public YoutubePlaylistItem(Snippet snippet)
        {
            Snippet = snippet;
        }
    }
}