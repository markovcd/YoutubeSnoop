using System.Linq;
using YoutubeSnoop.Api.Entities.Captions;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeCaptions Captions(CaptionApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<Caption, CaptionApiRequestSettings>(settings, partTypes);
            return new YoutubeCaptions(request);
        }

        public static YoutubeCaption Caption(CaptionApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<Caption, CaptionApiRequestSettings>(settings, partTypes);
            return new YoutubeCaption(request);
        }

        public static YoutubeCaptions Captions(CaptionApiRequestSettings settings = null)
        {
            return Captions(settings ?? new CaptionApiRequestSettings(), PartType.Snippet);
        }

        public static YoutubeCaption Caption(CaptionApiRequestSettings settings = null)
        {
            return Caption(settings ?? new CaptionApiRequestSettings(), PartType.Snippet);
        }
    }
}
