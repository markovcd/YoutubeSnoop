using System.Linq;
using YoutubeSnoop.Api.Entities.Captions;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeCaptions Captions(CaptionApiRequestSettings settings = null)
        {
            var request = DefaultRequest<Caption, CaptionApiRequestSettings>(settings ?? new CaptionApiRequestSettings(), new[] { PartType.Snippet });
            return new YoutubeCaptions(request);
        }

        public static YoutubeCaption Caption(CaptionApiRequestSettings settings = null)
        {
            var request = DefaultRequest<Caption, CaptionApiRequestSettings>(settings ?? new CaptionApiRequestSettings(), new[] { PartType.Snippet });
            return new YoutubeCaption(request);
        }

        public static YoutubeCaptions Captions(params string[] ids)
        {
            return Captions(new CaptionApiRequestSettings { Id = ids.Aggregate((s1, s2) => $"{s1},{s2}") });
        }

        public static YoutubeCaption Caption(string id)
        {
            return Caption(new CaptionApiRequestSettings { Id = id });
        }

        public static YoutubeCaptions RequestId(this YoutubeCaptions captions, params string[] ids)
        {
            var request = captions.Request.Clone();
            if (request.Settings.Id == null) request.Settings.Id = "";

            request.Settings.Id = request.Settings.Id.AddItems(ids);

            return new YoutubeCaptions(request);
        }

        public static YoutubeCaptions VideoId(this YoutubeCaptions captions, string id)
        {
            var request = captions.Request.Clone();
            request.Settings.VideoId = id;
            return new YoutubeCaptions(request);
        }
    }
}
