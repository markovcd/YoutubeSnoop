using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Api.Entities.Videos;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeVideos Videos(VideoApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<Video, VideoApiRequestSettings>(settings, partTypes);
            return new YoutubeVideos(request);
        }

        public static YoutubeVideo Video(VideoApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<Video, VideoApiRequestSettings>(settings, partTypes);
            return new YoutubeVideo(request);
        }

        public static YoutubeVideos Videos(VideoApiRequestSettings settings = null)
        {
            return Videos(settings ?? new VideoApiRequestSettings(), PartType.Snippet);
        }

        public static YoutubeVideo Video(VideoApiRequestSettings settings = null)
        {
            return Video(settings ?? new VideoApiRequestSettings(), PartType.Snippet);
        }

        public static YoutubeVideos Videos(IEnumerable<string> ids)
        {
            return Videos(new VideoApiRequestSettings { Id = ids.Aggregate((s1, s2) => $"{s1},{s2}") });
        }

        public static YoutubeVideo Video(string id)
        {
            return Video(new VideoApiRequestSettings { Id = id });
        }

        public static YoutubeVideos RequestId(this YoutubeVideos playlists, string id)
        {
            var request = playlists.Request.Clone();
            if (request.Settings.Id == null) request.Settings.Id = "";
            var ids = request.Settings.Id.Split(',').Append(id).Distinct();
            request.Settings.Id = ids.Aggregate((s1, s2) => $"{s1},{s2}");
            return new YoutubeVideos(request);
        }

        public static YoutubeVideos RequestPart(this YoutubeVideos playlists, PartType partType)
        {
            var request = playlists.Request.RequestPart(partType);
            return new YoutubeVideos(request);
        }

        public static YoutubeVideo RequestPart(this YoutubeVideo playlists, PartType partType)
        {
            var request = playlists.Request.RequestPart(partType);
            return new YoutubeVideo(request);
        }

        public static YoutubeSearch Related(this YoutubeVideo video)
        {
            return Search(new SearchApiRequestSettings { RelatedToVideoId = video.Id, Type = ResourceKind.Video });
        }

        public static YoutubeVideos MostPopular(this YoutubeVideos videos)
        {
            var request = videos.Request.Clone();
            request.Settings.Chart = Chart.MostPopular;
            return new YoutubeVideos(request);
        }
    }
}
