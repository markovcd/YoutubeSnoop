using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.ChannelSections;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeChannelSections : YoutubeCollection<YoutubeChannelSection, ChannelSection, ChannelSectionSettings>
    {
        public YoutubeChannelSections(ChannelSectionSettings settings = null, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
            : base(settings, partTypes, resultsPerPage)
        {
        }
    }
}