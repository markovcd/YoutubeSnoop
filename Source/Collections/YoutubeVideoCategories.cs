using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.VideoCategories;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeVideoCategories : YoutubeCollection<YoutubeVideoCategory, VideoCategory, VideoCategoryApiRequestSettings>
    {
        public YoutubeVideoCategories(IApiRequest<VideoCategory, VideoCategoryApiRequestSettings> request) : base(request)
        {
        }

        public YoutubeVideoCategories(VideoCategoryApiRequestSettings settings = null, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
            : base(settings, partTypes, resultsPerPage)
        {
        }
    }
}