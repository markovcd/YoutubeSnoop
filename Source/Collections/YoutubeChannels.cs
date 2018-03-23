using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Channels;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeChannels : YoutubeCollection<YoutubeChannel, Channel, ChannelApiRequestSettings>
    {
        public YoutubeChannels(IApiRequest<Channel, ChannelApiRequestSettings> request) : base(request)
        {
        }

        public YoutubeChannels(ChannelApiRequestSettings settings = null, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
            : base(settings, partTypes, resultsPerPage)
        {
        }
    }
}