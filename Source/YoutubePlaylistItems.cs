using System.Collections;
using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Entities.PlaylistItems;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubePlaylistItems : IYoutubeCollection<YoutubePlaylistItem>
    {
        public ApiRequest<PlaylistItem, PlaylistItemsApiRequestSettings> Request { get; }
        public IEnumerable<YoutubeVideo> Videos { get; }

        public YoutubePlaylistItems(PlaylistItemsApiRequestSettings settings, int resultsPerPage = 20)
        {
            Request = new ApiRequest<PlaylistItem, PlaylistItemsApiRequestSettings>(settings, resultsPerPage);
            Videos = this.Where(i => i.Kind == ResourceKind.Video).Select(i => (YoutubeVideo)i.Details);
        }

        public YoutubePlaylistItems(string playlistId)
            : this(new PlaylistItemsApiRequestSettings { PlaylistId = playlistId }) { }

        public IEnumerator<YoutubePlaylistItem> GetEnumerator()
        {
            return Request.Items.Select(i => new YoutubePlaylistItem(i)).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}