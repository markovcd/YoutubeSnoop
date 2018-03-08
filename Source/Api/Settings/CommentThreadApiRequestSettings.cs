using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Settings
{
    public sealed class CommentThreadApiRequestSettings : ApiRequestSettings
    {
        public override RequestType RequestType => RequestType.CommentThreads;

        /// <summary>
        /// Instructs the API to return all comment threads associated with the specified channel. The response can include comments about the channel or about the channel's videos.
        /// </summary>
        public string AllThreadsRelatedToChannelId { get; set; }

        /// <summary>
        /// Instructs the API to return comment threads containing comments about the specified channel. (The response will not include comments left on videos that the channel uploaded.)
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// Specifies a comma-separated list of comment thread IDs for the resources that should be retrieved.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Instructs the API to return comment threads associated with the specified video ID.
        /// </summary>
        public string VideoId { get; set; }

        /// <summary>
        /// Parameter indicates whether the API should return comments formatted as HTML or as plain text. The default value is html.
        /// </summary>
        public TextFormat? TextFormat { get; set; }

        /// <summary>
        /// Specifies the order in which the API response should list comment threads.
        /// </summary>
        public CommentOrder? Order { get; set; }

        /// <summary>
        /// Instructs the API to limit the API response to only contain comments that contain the specified search terms.
        /// </summary>
        /// <remarks>
        /// Note: This parameter is not supported for use in conjunction with the id parameter.
        /// </remarks>
        public string SearchTerms { get; set; }
    }
}