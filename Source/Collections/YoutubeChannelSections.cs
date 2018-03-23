using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.ChannelSections;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeChannelSections : YoutubeCollection<YoutubeChannelSection, ChannelSection, ChannelSectionApiRequestSettings>
    {
        public YoutubeChannelSections(IApiRequest<ChannelSection, ChannelSectionApiRequestSettings> request) : base(request)
        {
        }

        public YoutubeChannelSections(ChannelSectionApiRequestSettings settings = null, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
            : base(settings, partTypes, resultsPerPage)
        {
        }
    }
}