using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.GuideCategories;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeGuideCategories : YoutubeCollection<YoutubeGuideCategory, GuideCategory, GuideCategorySettings>
    {
        public YoutubeGuideCategories(GuideCategorySettings settings, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
            : base(settings, partTypes, resultsPerPage)
        {
        }
    }
}