using System;
using System.Collections.Generic;
using System.Text;
using YoutubeSnoop.ApiRequests.Arguments;

namespace YoutubeSnoop.ApiRequests.Settings
{
    enum SearchOrder
    {
        Date, Rating, Relevance, Title, VideoCount, ViewCount
    }

    enum SafeSearch
    {
        None, Moderate, Strict
    }

    enum Duration
    {
        Any, Long, Medium, Short
    }

    class SearchApiRequestSettings : IApiRequestSettings
    {
        public ApiRequestType RequestType => ApiRequestType.Search;

        public string Query { get; set; }
        public string Id { get; set; }
        public string PageToken { get; set; }
        public int MaxResults { get; set; }
        public string ChannelId { get; set; }
        public SearchOrder Order { get; set; }
        public DateTime PublishedAfter { get; set; }
        public DateTime PublishedBefore { get; set; }
        public string RelatedToVideoId { get; set; }
        public SafeSearch SafeSearch { get; set; }
        public string TopicId { get; set; }
        public string VideoCategoryId { get; set; }
        public Duration VideoDuration { get; set; }

        public IEnumerable<ApiArgument> GetArguments()
        {
            yield return new ApiPartArgument(PartType.Snippet);
            yield return new ApiArgument("q", Query);
            yield return new ApiArgument("pageToken", PageToken);
            yield return new ApiArgument<int>("maxResults", MaxResults);
            yield return new ApiArgument("channelId", ChannelId);
            yield return new ApiArgument<SearchOrder>("order", Order);
            yield return new ApiArgument<DateTime>("publishedAfter", PublishedAfter);
            yield return new ApiArgument<DateTime>("publishedBefore", PublishedBefore);
            yield return new ApiArgument("relatedToVideoId", RelatedToVideoId);
            yield return new ApiArgument<SafeSearch>("safeSearch", SafeSearch);
            yield return new ApiArgument("topicId", TopicId);
            // todo: type
            yield return new ApiArgument("videoCategoryId", VideoCategoryId);
            yield return new ApiArgument<Duration>("videoDuration", VideoDuration);
        }
    }
}
