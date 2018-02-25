using YoutubeSnoop.ApiRequests.Settings;
using YoutubeSnoop.Entities;

namespace YoutubeSnoop.ApiRequests
{
    public class PlaylistApiRequest : ApiRequest<PlaylistItemListResponse, PlaylistItem>
    {
        public PlaylistApiRequest(PlaylistApiRequestSettings settings, int maxResults = 20, string pageToken = null)
            : base(ApiRequestType.PlaylistItems, maxResults, settings, pageToken) { }
    }
}
