using System.Linq;
using YoutubeSnoop.Api.Entities.VideoCategories;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeVideoCategories VideoCategories(VideoCategoryApiRequestSettings settings = null)
        {
            var request = GetDefaultRequest<VideoCategory, VideoCategoryApiRequestSettings>(settings ?? new VideoCategoryApiRequestSettings(), new[] { PartType.Snippet });
            return new YoutubeVideoCategories(request);
        }

        public static YoutubeVideoCategory VideoCategory(VideoCategoryApiRequestSettings settings = null)
        {
            var request = GetDefaultRequest<VideoCategory, VideoCategoryApiRequestSettings>(settings ?? new VideoCategoryApiRequestSettings(), new[] { PartType.Snippet });
            return new YoutubeVideoCategory(request);
        }

        public static YoutubeVideoCategories VideoCategories(params string[] ids)
        {
            return VideoCategories(new VideoCategoryApiRequestSettings { Id = ids.Aggregate((s1, s2) => $"{s1},{s2}") });
        }

        public static YoutubeVideoCategory VideoCategory(string id)
        {
            return VideoCategory(new VideoCategoryApiRequestSettings { Id = id });
        }

        public static YoutubeVideoCategories RequestId(this YoutubeVideoCategories videoCategories, params string[] ids)
        {
            var request = videoCategories.Request.Clone();
            if (request.Settings.Id == null) request.Settings.Id = "";

            request.Settings.Id = request.Settings.Id.AddItems(ids);

            return new YoutubeVideoCategories(request);
        }

        public static YoutubeVideoCategories ForCountry(this YoutubeVideoCategories videoCategories, string regionCode)
        {
            var request = videoCategories.Request.Clone();
            request.Settings.RegionCode = regionCode;
            return new YoutubeVideoCategories(request);
        }

        public static YoutubeChannel Channel(this YoutubeVideoCategory videoCategory)
        {
            return Channel(videoCategory.ChannelId);
        }
    }
}