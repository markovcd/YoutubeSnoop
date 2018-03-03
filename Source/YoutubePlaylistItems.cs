using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Entities.PlaylistItems;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubePlaylistItems : YoutubeCollectionRequest<PlaylistItemsApiRequestSettings, PlaylistItem>, IYoutubeCollection<YoutubePlaylistItem>
    {
        public IList<YoutubePlaylistItem> Items { get; }

        public YoutubePlaylistItems(PlaylistItemsApiRequestSettings settings) : base(settings)
        {
            Items = Responses.Select(i => new YoutubePlaylistItem(i)).ToList();
        }

        public YoutubePlaylistItems(string playlistId)
            : this(new PlaylistItemsApiRequestSettings { PlaylistId = playlistId }) { }
    }
}