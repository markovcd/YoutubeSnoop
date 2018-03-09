using System.Linq;
using YoutubeSnoop.Api.Entities.GuideCategories;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeGuideCategories GuideCategories(GuideCategoryApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<GuideCategory, GuideCategoryApiRequestSettings>(settings, partTypes);
            return new YoutubeGuideCategories(request);
        }

        public static YoutubeGuideCategory GuideCategory(GuideCategoryApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<GuideCategory, GuideCategoryApiRequestSettings>(settings, partTypes);
            return new YoutubeGuideCategory(request);
        }

        public static YoutubeGuideCategories GuideCategories(GuideCategoryApiRequestSettings settings = null)
        {
            return GuideCategories(settings ?? new GuideCategoryApiRequestSettings(), PartType.Snippet);
        }

        public static YoutubeGuideCategory GuideCategory(GuideCategoryApiRequestSettings settings = null)
        {
            return GuideCategory(settings ?? new GuideCategoryApiRequestSettings(), PartType.Snippet);
        }


    }
}
