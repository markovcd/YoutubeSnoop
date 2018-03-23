using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.GuideCategories;
using YoutubeSnoop.Api.Settings;

namespace YoutubeSnoop
{
    public sealed class YoutubeGuideCategories : YoutubeCollection<YoutubeGuideCategory, GuideCategory, GuideCategoryApiRequestSettings>
    {
        public YoutubeGuideCategories(IApiRequest<GuideCategory, GuideCategoryApiRequestSettings> request) : base(request)
        {
        }
    }
}