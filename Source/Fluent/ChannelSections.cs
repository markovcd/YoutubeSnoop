using System.Linq;
using YoutubeSnoop.Api.Entities.ChannelSections;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeChannelSections ChannelSections(ChannelSectionApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<ChannelSection, ChannelSectionApiRequestSettings>(settings, partTypes);
            return new YoutubeChannelSections(request);
        }

        public static YoutubeChannelSection ChannelSection(ChannelSectionApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<ChannelSection, ChannelSectionApiRequestSettings>(settings, partTypes);
            return new YoutubeChannelSection(request);
        }

        public static YoutubeChannelSections ChannelSections(ChannelSectionApiRequestSettings settings = null)
        {
            return ChannelSections(settings ?? new ChannelSectionApiRequestSettings(), PartType.Snippet);
        }

        public static YoutubeChannelSection ChannelSection(ChannelSectionApiRequestSettings settings = null)
        {
            return ChannelSection(settings ?? new ChannelSectionApiRequestSettings(), PartType.Snippet);
        }
    }
}
