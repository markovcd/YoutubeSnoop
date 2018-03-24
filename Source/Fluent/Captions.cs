using YoutubeSnoop.Api.Settings;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeCaptions Captions(CaptionApiRequestSettings settings = null)
        {
            return new YoutubeCaptions(settings, null, ResultsPerPage);
        }

        public static YoutubeCaption Caption(CaptionApiRequestSettings settings = null)
        {
            return new YoutubeCaption(settings);
        }

        public static YoutubeCaptions Captions(params string[] ids)
        {
            return Captions(new CaptionApiRequestSettings { Id = ids.Aggregate() });
        }

        public static YoutubeCaption Caption(string id)
        {
            return Caption(new CaptionApiRequestSettings { Id = id });
        }

        public static YoutubeCaptions RequestId(this YoutubeCaptions captions, params string[] ids)
        {
            var settings = captions.Settings.Clone();
            settings.Id = settings.Id.AddItems(ids);
            return Captions(settings);
        }

        public static YoutubeCaptions ForVideoId(this YoutubeCaptions captions, string id)
        {
            var settings = captions.Settings.Clone();
            settings.VideoId = id;
            return Captions(settings);
        }
    }
}