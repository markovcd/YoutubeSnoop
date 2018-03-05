using System.Collections;
using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Entities.Channels;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;
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