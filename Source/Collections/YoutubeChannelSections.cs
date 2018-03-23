using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.ChannelSections;
using YoutubeSnoop.Api.Settings;

namespace YoutubeSnoop
{
    public sealed class YoutubeChannelSections : YoutubeCollection<YoutubeChannelSection, ChannelSection, ChannelSectionApiRequestSettings>
    {
        public YoutubeChannelSections(IApiRequest<ChannelSection, ChannelSectionApiRequestSettings> request) : base(request)
        {
        }
    }
}