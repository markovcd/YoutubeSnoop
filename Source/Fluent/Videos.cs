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

        public static YoutubeVideos Videos(params string[] ids)
        {
            return Videos(new VideoApiRequestSettings { Id = ids.Aggregate((s1, s2) => $"{s1},{s2}") });
        }

        public static YoutubeVideo Video(string id)
        {
            return Video(new VideoApiRequestSettings { Id = id });
        }

        public static YoutubeVideos RequestId(this YoutubeVideos videos, params string[] ids)
        {
            var request = videos.Request.Clone();
            if (request.Settings.Id == null) request.Settings.Id = "";

            request.Settings.Id = request.Settings.Id.AddItems(ids);

            return new YoutubeVideos(request);
        }

        public static YoutubeVideos RequestPart(this YoutubeVideos videos, PartType partType)
        {
            var request = videos.Request.RequestPart(partType);
            return new YoutubeVideos(request);
        }

        public static YoutubeVideos RequestContentDetails(this YoutubeVideos videos)
        {
            return videos.RequestPart(PartType.ContentDetails);
        }

        public static YoutubeVideos RequestStatistics(this YoutubeVideos videos)
        {
            return videos.RequestPart(PartType.Statistics);
        }

        public static YoutubeVideos RequestStatus(this YoutubeVideos videos)
        {
            return videos.RequestPart(PartType.Status);
        }

        public static YoutubeVideos RequestLocalizations(this YoutubeVideos videos)
        {
            return videos.RequestPart(PartType.Localizations);
        }

        public static YoutubeVideos RequestPlayer(this YoutubeVideos videos)
        {
            return videos.RequestPart(PartType.Player);
        }

        public static YoutubeVideos RequestTopicDetails(this YoutubeVideos videos)
        {
            return videos.RequestPart(PartType.TopicDetails);
        }

        public static YoutubeVideos RequestRecordingDetails(this YoutubeVideos videos)
        {
            return videos.RequestPart(PartType.RecordingDetails);
        }

        public static YoutubeVideos RequestLiveStreamingDetails(this YoutubeVideos videos)
        {
            return videos.RequestPart(PartType.LiveStreamingDetails);
        }

        public static YoutubeVideos RequestSnippet(this YoutubeVideos videos)
        {
            return videos.RequestPart(PartType.Snippet);
        }

        public static YoutubeVideos RequestAllParts(this YoutubeVideos videos)
        {
            return videos.RequestContentDetails()
                         .RequestStatistics()
                         .RequestStatus()
                         .RequestLocalizations()
                         .RequestPlayer()
                         .RequestTopicDetails()
                         .RequestRecordingDetails()
                         .RequestLiveStreamingDetails()
                         .RequestSnippet(); 
        }

        public static YoutubeVideo RequestPart(this YoutubeVideo video, PartType partType)
        {
            var request = video.Request.RequestPart(partType);
            return new YoutubeVideo(request);
        }

        public static YoutubeVideo RequestContentDetails(this YoutubeVideo video)
        {
            return video.RequestPart(PartType.ContentDetails);
        }

        public static YoutubeVideo RequestStatistics(this YoutubeVideo video)
        {
            return video.RequestPart(PartType.Statistics);
        }

        public static YoutubeVideo RequestStatus(this YoutubeVideo video)
        {
            return video.RequestPart(PartType.Status);
        }

        public static YoutubeVideo RequestLocalizations(this YoutubeVideo video)
        {
            return video.RequestPart(PartType.Localizations);
        }

        public static YoutubeVideo RequestPlayer(this YoutubeVideo video)
        {
            return video.RequestPart(PartType.Player);
        }

        public static YoutubeVideo RequestTopicDetails(this YoutubeVideo video)
        {
            return video.RequestPart(PartType.TopicDetails);
        }

        public static YoutubeVideo RequestRecordingDetails(this YoutubeVideo video)
        {
            return video.RequestPart(PartType.RecordingDetails);
        }

        public static YoutubeVideo RequestLiveStreamingDetails(this YoutubeVideo video)
        {
            return video.RequestPart(PartType.LiveStreamingDetails);
        }

        public static YoutubeVideo RequestSnippet(this YoutubeVideo video)
        {
            return video.RequestPart(PartType.Snippet);
        }

        public static YoutubeVideo RequestAllParts(this YoutubeVideo video)
        {
            return video.RequestContentDetails()
                        .RequestStatistics()
                        .RequestStatus()
                        .RequestLocalizations()
                        .RequestPlayer()
                        .RequestTopicDetails()
                        .RequestRecordingDetails()
                        .RequestLiveStreamingDetails()
                        .RequestSnippet();
        }

        public static YoutubeSearch RelatedVideos(this YoutubeVideo video)
        {
            return Search().RelatedToVideoId(video.Id);
        }

        public static YoutubeCommentThreads Comments(this YoutubeVideo video)
        {
            return CommentThreads().ForVideoId(video.Id);
        }

        public static YoutubeVideos MostPopular(this YoutubeVideos videos)
        {
            var request = videos.Request.Clone();
            request.Settings.Chart = Chart.MostPopular;
            return new YoutubeVideos(request);
        }
    }
}
