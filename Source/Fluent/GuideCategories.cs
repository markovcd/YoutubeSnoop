using YoutubeSnoop.Api;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeGuideCategories GuideCategories(GuideCategorySettings settings = null)
        {
            return new YoutubeGuideCategories(settings, null, ResultsPerPage);
        }

        public static YoutubeGuideCategory GuideCategory(GuideCategorySettings settings = null)
        {
           return new YoutubeGuideCategory(settings);
        }

        public static YoutubeGuideCategories GuideCategories(params string[] ids)
        {
            return GuideCategories(new GuideCategorySettings { Id = ids.Aggregate() });
        }

        public static YoutubeGuideCategory GuideCategory(string id)
        {
            return GuideCategory(new GuideCategorySettings { Id = id });
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