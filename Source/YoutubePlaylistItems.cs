using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.PlaylistItems;
using YoutubeSnoop.Api.Settings;

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