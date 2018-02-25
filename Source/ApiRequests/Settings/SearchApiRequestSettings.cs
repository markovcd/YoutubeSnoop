using System;
using System.Collections.Generic;
using YoutubeSnoop.ApiRequests.Arguments;

namespace YoutubeSnoop.ApiRequests.Settings
{
    public enum SearchOrder
    {
        Date, Rating, Relevance, Title, VideoCount, ViewCount
    }

    public enum SafeSearch
    {
        None, Moderate, Strict
    }

    public enum Duration
    {
        Any, Long, Medium, Short
    }

    public class SearchApiRequestSettings : Interfaces.IApiRequestSettings
    {
        public string Query { get; set; }
        public string Id { get; set; }
        public string ChannelId { get; set; }
        public SearchOrder? Order { get; set; }
        public DateTime? PublishedAfter { get; set; }
        public DateTime? PublishedBefore { get; set; }
        public string RelatedToVideoId { get; set; }
        public SafeSearch? SafeSearch { get; set; }
        public string TopicId { get; set; }
        public string VideoCategoryId { get; set; }
        public Duration? VideoDuration { get; set; }

        public IEnumerable<ApiArgument> GetArguments()
        {
            yield return new ApiArgument("q", Query);
            yield return new ApiArgument("channelId", ChannelId);
            yield return new ApiArgument<SearchOrder?>("order", Order);
            yield return new ApiArgument<DateTime?>("publishedAfter", PublishedAfter);
            yield return new ApiArgument<DateTime?>("publishedBefore", PublishedBefore);
            yield return new ApiArgument("relatedToVideoId", RelatedToVideoId);
            yield return new ApiArgument<SafeSearch?>("safeSearch", SafeSearch);
            yield return new ApiArgument("topicId", TopicId);
            // todo: type
            yield return new ApiArgument("videoCategoryId", VideoCategoryId);
            yield return new ApiArgument<Duration?>("videoDuration", VideoDuration);
        }
    }
}
