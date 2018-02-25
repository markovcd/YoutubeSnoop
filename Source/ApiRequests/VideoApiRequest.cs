using YoutubeSnoop.ApiRequests.Settings;
using YoutubeSnoop.Entities;

namespace YoutubeSnoop.ApiRequests
{
    public class VideoApiRequest : ApiRequest<VideoListResponse, Video>
    {
        public VideoApiRequest(VideoApiRequestSettings settings, int maxResults = 20, string pageToken = null)
            : base(ApiRequestType.Videos, maxResults, settings, pageToken) { }
    }
}
