using System.Linq;
using YoutubeSnoop.Api.Entities.GuideCategories;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeGuideCategories GuideCategories(GuideCategoryApiRequestSettings settings = null)
        {
            var request = DefaultRequest<GuideCategory, GuideCategoryApiRequestSettings>(settings ?? new GuideCategoryApiRequestSettings(), new[] { PartType.Snippet });
            return new YoutubeGuideCategories(request);
        }

        public static YoutubeGuideCategory GuideCategory(GuideCategoryApiRequestSettings settings = null)
        {
            var request = DefaultRequest<GuideCategory, GuideCategoryApiRequestSettings>(settings ?? new GuideCategoryApiRequestSettings(), new[] { PartType.Snippet });
            return new YoutubeGuideCategory(request);
        }

        public static YoutubeGuideCategories GuideCategories(params string[] ids)
        {
            return GuideCategories(new GuideCategoryApiRequestSettings { Id = ids.Aggregate((s1, s2) => $"{s1},{s2}") });
        }

        public static YoutubeGuideCategory GuideCategory(string id)
        {
            return GuideCategory(new GuideCategoryApiRequestSettings { Id = id });
        }

        public static YoutubeGuideCategories ForRegion(this YoutubeGuideCategories guideCategories, string regionCode)
        {
            var request = guideCategories.Request.Clone();
            request.Settings.RegionCode = regionCode;
            return new YoutubeGuideCategories(request);
        }

        public static YoutubeChannel Channel(this YoutubeGuideCategory guideCategory)
        {
            return Channel(guideCategory.Item?.Snippet?.ChannelId);
        }

    }
}
