using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Videos;
using YoutubeSnoop.Api.Settings;

namespace YoutubeSnoop
{
    public sealed class YoutubeVideos : YoutubeCollection<YoutubeVideo, Video, VideoApiRequestSettings>
    {
        public YoutubeVideos(IApiRequest<Video, VideoApiRequestSettings> request) : base(request)
        {
        }
    }
}