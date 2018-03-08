using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Captions;
using YoutubeSnoop.Api.Settings;

namespace YoutubeSnoop
{
    public class YoutubeCaptions : YoutubeCollection<YoutubeCaption, Caption, CaptionApiRequestSettings>
    {        
        public YoutubeCaptions(IApiRequest<Caption, CaptionApiRequestSettings> request) : base(request) {  }

        protected override YoutubeCaption CreateItem(Caption response)
        {
            return new YoutubeCaption(response);
        }
    }
}