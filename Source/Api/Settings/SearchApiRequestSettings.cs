using System;
using YoutubeSnoop.Api.Attributes;
using YoutubeSnoop.Api.Converters;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Settings
{
    public sealed class SearchApiRequestSettings : ApiRequestSettings
    {
        public override RequestType RequestType => RequestType.Search;

        /// <summary>
        /// The q parameter specifies the query term to search for.
        /// </summary>
        /// <remarks>
        /// Your request can also use the Boolean NOT (-) and OR (|) operators to exclude videos or to find videos that are associated with one of several search terms. For example, to search for videos matching either "boating" or "sailing", set the q parameter value to boating|sailing. Similarly, to search for videos matching either "boating" or "sailing" but not "fishing", set the q parameter value to boating|sailing -fishing. Note that the pipe character must be URL-escaped when it is sent in your API request. The URL-escaped value for the pipe character is %7C.
        /// </remarks>
        [ApiRequestArgumentName("q")]
        public string Query { get; set; }

        /// <summary>
        /// Parameter indicates that the API response should only contain resources created by the channel. 
        /// </summary>
        /// <remarks>
        /// Note: Search results are constrained to a maximum of 500 videos if your request specifies a value for the channelId parameter and sets the type parameter value to video.
        /// </remarks>
        public string ChannelId { get; set; }

        /// <summary>
        /// Lets you restrict a search to a particular type of channel.
        /// </summary>
        public ChannelType? ChannelType { get; set; }

        /// <summary>
        /// Restricts a search to broadcast events. If you specify a value for this parameter, you must also set the type parameter's value to video.
        /// </summary>
        public EventType? EventType { get; set; }

        /// <summary>
        /// The location parameter, in conjunction with the locationRadius parameter, defines a circular geographic area and also restricts a search to videos that specify, in their metadata, a geographic location that falls within that area. 
        /// </summary>
        /// <remarks>
        /// The API returns an error if your request specifies a value for the location parameter but does not also specify a value for the locationRadius parameter.
        /// </remarks>
        public Entities.Location Location { get; set; }

        /// <summary>
        /// The locationRadius parameter, in conjunction with the location parameter, defines a circular geographic area.
        /// </summary>
        public Entities.Distance LocationRadius { get; set; }

        /// <summary>
        /// Specifies the method that will be used to order resources in the API response. The default value is relevance.
        /// </summary>
        public SearchOrder? Order { get; set; }

        /// <summary>
        /// Indicates that the API response should only contain resources created at or after the specified time.
        /// </summary>
        [ApiRequestConverter(typeof(DateTimeConverter))]
        public DateTime? PublishedAfter { get; set; }

        /// <summary>
        /// Indicates that the API response should only contain resources created before or at the specified time. 
        /// </summary>
        [ApiRequestConverter(typeof(DateTimeConverter))]
        public DateTime? PublishedBefore { get; set; }

        /// <summary>
        /// Instructs the API to return search results for videos that can be viewed in the specified country. The parameter value is an ISO 3166-1 alpha-2 country code.
        /// </summary>
        public string RegionCode { get; set; }

        /// <summary>
        /// Retrieves a list of videos that are related to the video that the parameter value identifies. The parameter value must be set to a YouTube video ID and, if you are using this parameter, the type parameter must be set to video.
        /// </summary>
        /// <remarks>
        /// Note that if the relatedToVideoId parameter is set, the only other supported parameters are regionCode, relevanceLanguage, safeSearch, type (which must be set to video).
        /// </remarks>
        public string RelatedToVideoId { get; set; }
   
        /// <summary>
        /// Instructs the API to return search results that are most relevant to the specified language. The parameter value is typically an ISO 639-1 two-letter language code. However, you should use the values zh-Hans for simplified Chinese and zh-Hant for traditional Chinese. Please note that results in other languages will still be returned if they are highly relevant to the search query term.
        /// </summary>
        public string RelevanceLanguage { get; set; }

        /// <summary>
        /// Indicates whether the search results should include restricted content as well as standard content.
        /// </summary>
        public SafeSearch? SafeSearch { get; set; }

        /// <summary>
        /// Indicates that the API response should only contain resources associated with the specified topic. The value identifies a Freebase topic ID.
        /// </summary>
        /// <remarks>
        /// Important: Due to the deprecation of Freebase and the Freebase API, the topicId parameter started working differently as of February 27, 2017. At that time, YouTube started supporting a small set of curated topic IDs, and you can only use that smaller set of IDs as values for this parameter.
        /// </remarks>
        public string TopicId { get; set; }

        /// <summary>
        /// Filters video search results based on their category. If you specify a value for this parameter, you must also set the type parameter's value to video.
        /// </summary>
        public string VideoCategoryId { get; set; }

        /// <summary>
        /// Filters video search results based on their duration. If you specify a value for this parameter, you must also set the type parameter's value to video.
        /// </summary>
        public Duration? VideoDuration { get; set; }

        /// <summary>
        /// Restricts a search query to only retrieve a particular type of resource. The value is a comma-separated list of resource types. The default value is video,channel,playlist.
        /// </summary>
        public ResourceKind? Type { get; set; } // TODO - support multiple resourcekinds !!!!!!!

        /// <summary>
        /// Indicates whether the API should filter video search results based on whether they have captions. If you specify a value for this parameter, you must also set the type parameter's value to video.
        /// </summary>
        public Caption? VideoCaption { get; set; }

        /// <summary>
        /// Lets you restrict a search to only include either high definition (HD) or standard definition (SD) videos. HD videos are available for playback in at least 720p, though higher resolutions, like 1080p, might also be available. If you specify a value for this parameter, you must also set the type parameter's value to video.
        /// </summary>
        public Definition? VideoDefinition { get; set; }

        /// <summary>
        /// Lets you restrict a search to only retrieve 2D or 3D videos. If you specify a value for this parameter, you must also set the type parameter's value to video.
        /// </summary>
        [ApiRequestConverter(typeof(EnumDescriptionConverter))]
        public Dimension? VideoDimension { get; set; }

        /// <summary>
        /// Lets you to restrict a search to only videos that can be embedded into a webpage. If you specify a value for this parameter, you must also set the type parameter's value to video.
        /// </summary>
        public AnyOrTrue? VideoEmbeddable { get; set; }

        /// <summary>
        /// Filters search results to only include videos with a particular license. YouTube lets video uploaders choose to attach either the Creative Commons license or the standard YouTube license to each of their videos. If you specify a value for this parameter, you must also set the type parameter's value to video.
        /// </summary>
        public License? VideoLicense { get; set; }

        /// <summary>
        /// Lets you to restrict a search to only videos that can be played outside youtube.com. If you specify a value for this parameter, you must also set the type parameter's value to video.
        /// </summary>
        public AnyOrTrue? VideoSyndicated { get; set; }

        /// <summary>
        /// Lets you restrict a search to a particular type of videos. If you specify a value for this parameter, you must also set the type parameter's value to video.
        /// </summary>
        public VideoType? VideoType { get; set; }
    }
}