using YoutubeSnoop.Api;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeVideoCategories VideoCategories(VideoCategorySettings settings = null)
        {
            return new YoutubeVideoCategories(settings, null, ResultsPerPage);
        }

        public static YoutubeVideoCategory VideoCategory(VideoCategorySettings settings = null)
        {
            return new YoutubeVideoCategory(settings, null);
        }

        public static YoutubeVideoCategories VideoCategories(params string[] ids)
        {
            return VideoCategories(new VideoCategorySettings { Id = ids.Aggregate() });
        }

        public static YoutubeVideoCategory VideoCategory(string id)
        {
            return VideoCategory(new VideoCategorySettings { Id = id });
        }

        public static YoutubeVideoCategories RequestId(this YoutubeVideoCategories videoCategories, params string[] ids)
        {
            var settings = videoCategories.Settings.Clone();
            settings.Id = settings.Id.AddItems(ids);
            return VideoCategories(settings);
        }

        public static YoutubeVideoCategories ForCountry(this YoutubeVideoCategories videoCategories, string regionCode)
        {
            var settings = videoCategories.Settings.Clone();
            settings.RegionCode = regionCode;
            return VideoCategories(settings);
        }

        public static YoutubeChannel Channel(this YoutubeVideoCategory videoCategory)
        {
            return Channel(videoCategory.ChannelId);
        }
    }
}