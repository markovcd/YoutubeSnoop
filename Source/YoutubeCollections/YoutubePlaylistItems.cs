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
        public IApiRequest<PlaylistItem> Request { get; }

        public YoutubePlaylistItems(IApiRequest<PlaylistItem> request)
        {
            Request = request;
        }

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