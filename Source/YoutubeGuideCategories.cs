using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.GuideCategories;
using YoutubeSnoop.Api.Settings;

namespace YoutubeSnoop
{
    public sealed class YoutubeGuideCategories : YoutubeCollection<YoutubeGuideCategory, GuideCategory, GuideCategoryApiRequestSettings>
    {        
        public YoutubeGuideCategories(IApiRequest<GuideCategory, GuideCategoryApiRequestSettings> request) : base(request) {  }

        protected override YoutubeGuideCategory CreateItem(GuideCategory response)
        {
            return new YoutubeGuideCategory(response);
        }
    }
}