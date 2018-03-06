using YoutubeSnoop.Entities.Channels;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubeChannels : YoutubeCollection<YoutubeChannel, Channel, ChannelApiRequestSettings>
    {        
        public YoutubeChannels(IApiRequest<Channel, ChannelApiRequestSettings> request) : base(request) {  }

        protected override YoutubeChannel CreateItem(Channel response)
        {
            return new YoutubeChannel(response);
        }
    }
}