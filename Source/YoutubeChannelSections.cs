using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.ChannelSections;
using YoutubeSnoop.Api.Settings;

namespace YoutubeSnoop
{
    public class YoutubeChannelSections : YoutubeCollection<YoutubeChannelSection, ChannelSection, ChannelSectionApiRequestSettings>
    {        
        public YoutubeChannelSections(IApiRequest<ChannelSection, ChannelSectionApiRequestSettings> request) : base(request) {  }

        protected override YoutubeChannelSection CreateItem(ChannelSection response)
        {
            return new YoutubeChannelSection(response);
        }
    }
}