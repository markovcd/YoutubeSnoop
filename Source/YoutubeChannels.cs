using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Channels;
using YoutubeSnoop.Api.Settings;

namespace YoutubeSnoop
{
    public sealed class YoutubeChannels : YoutubeCollection<YoutubeChannel, Channel, ChannelApiRequestSettings>
    {
        public YoutubeChannels(IApiRequest<Channel, ChannelApiRequestSettings> request) : base(request)
        {
        }

        protected override YoutubeChannel CreateItem(Channel response)
        {
            return new YoutubeChannel(response);
        }
    }
}