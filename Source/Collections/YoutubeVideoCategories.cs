using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.VideoCategories;
using YoutubeSnoop.Api.Settings;

namespace YoutubeSnoop
{
    public sealed class YoutubeVideoCategories : YoutubeCollection<YoutubeVideoCategory, VideoCategory, VideoCategoryApiRequestSettings>
    {
        public YoutubeVideoCategories(IApiRequest<VideoCategory, VideoCategoryApiRequestSettings> request) : base(request)
        {
        }
    }
}