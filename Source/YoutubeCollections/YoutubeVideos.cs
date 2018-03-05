using YoutubeSnoop.Entities.Videos;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubeVideos : YoutubeCollection<YoutubeVideo, Video, VideoApiRequestSettings>
    {
        public YoutubeVideos(IApiRequest<Video, VideoApiRequestSettings> request) : base(request) { }

        protected override YoutubeVideo CreateItem(Video response)
        {
            return YoutubeVideo.FromResponse(response);
        }
    }
}