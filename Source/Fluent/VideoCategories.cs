using System.Linq;
using YoutubeSnoop.Api.Entities.VideoCategories;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeVideoCategories VideoCategories(VideoCategoryApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<VideoCategory, VideoCategoryApiRequestSettings>(settings, partTypes);
            return new YoutubeVideoCategories(request);
        }

        public static YoutubeVideoCategory VideoCategory(VideoCategoryApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<VideoCategory, VideoCategoryApiRequestSettings>(settings, partTypes);
            return new YoutubeVideoCategory(request);
        }

        public static YoutubeVideoCategories VideoCategories(VideoCategoryApiRequestSettings settings = null)
        {
            return VideoCategories(settings ?? new VideoCategoryApiRequestSettings(), PartType.Snippet);
        }

        public static YoutubeVideoCategory VideoCategory(VideoCategoryApiRequestSettings settings = null)
        {
            return VideoCategory(settings ?? new VideoCategoryApiRequestSettings(), PartType.Snippet);
        }
    }
}
