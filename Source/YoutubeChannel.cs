using YoutubeSnoop.Entities.Channels;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubeChannel : YoutubeRequest<ChannelApiRequestSettings, Channel>, IYoutubeItem
    {
        private const string _youtubeUrl = @"https://www.youtube.com/channel/{0}";

        public YoutubeChannel(string id) : this(new ChannelApiRequestSettings { Id = id }) { }

        public YoutubeChannel(ChannelApiRequestSettings settings) : base(settings)
        {
            Id = Response.Id;
            Url = string.Format(_youtubeUrl, Id);
        }

        public string Url { get; }
        public string Id { get; }
    }
}