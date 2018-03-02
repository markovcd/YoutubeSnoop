using YoutubeSnoop.Entities.Videos;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubeVideo : YoutubeRequest<VideoApiRequestSettings, Snippet, Video>, IYoutubeItem<Snippet>
    {
        private const string _youtubeUrl = @"https://www.youtube.com/watch?v={0}";

        public YoutubeVideo(string id) : this(new VideoApiRequestSettings { Id = id }) { }

        public YoutubeVideo(VideoApiRequestSettings settings) : base(settings)
        {
            Id = settings.Id;
            Url = string.Format(_youtubeUrl, Id);
        }

        public string Url { get; }
        public string Id { get; }
    }
}