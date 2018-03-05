using YoutubeSnoop.Entities.PlaylistItems;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubePlaylistItems : YoutubeCollection<YoutubePlaylistItem, PlaylistItem, PlaylistItemsApiRequestSettings>
    {
        public YoutubePlaylistItems(IApiRequest<PlaylistItem, PlaylistItemsApiRequestSettings> request) : base(request) { }

        protected override YoutubePlaylistItem CreateItem(PlaylistItem response)
        {
            return new YoutubePlaylistItem(response);
        }
    }
}