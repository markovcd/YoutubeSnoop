using YoutubeSnoop.Api.Settings;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeGuideCategories GuideCategories(GuideCategoryApiRequestSettings settings = null)
        {
            return new YoutubeGuideCategories(settings, null, ResultsPerPage);
        }

        public static YoutubeGuideCategory GuideCategory(GuideCategoryApiRequestSettings settings = null)
        {
           return new YoutubeGuideCategory(settings);
        }

        public static YoutubeGuideCategories GuideCategories(params string[] ids)
        {
            return GuideCategories(new GuideCategoryApiRequestSettings { Id = ids.Aggregate() });
        }

        public static YoutubeGuideCategory GuideCategory(string id)
        {
            return GuideCategory(new GuideCategoryApiRequestSettings { Id = id });
        }

        public static YoutubeGuideCategories ForRegion(this YoutubeGuideCategories guideCategories, string regionCode)
        {
            var settings = guideCategories.Settings.Clone();
            settings.RegionCode = regionCode;
            return GuideCategories(settings);
        }

        public static YoutubeChannel Channel(this YoutubeGuideCategory guideCategory)
        {
            if (guideCategory.ChannelId == null) return null;
            return Channel(guideCategory.ChannelId);
        }
    }
}