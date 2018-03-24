using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.VideoCategories;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeVideoCategories : YoutubeCollection<YoutubeVideoCategory, VideoCategory, VideoCategorySettings>
    {
        public YoutubeVideoCategories(VideoCategorySettings settings, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
            : base(settings, partTypes, resultsPerPage)
        {
        }
    }
}