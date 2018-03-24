using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api
{
    public sealed class CommentSettings : Settings
    {
        public override RequestType RequestType => RequestType.Comments;

        /// <summary>
        /// Specifies a comma-separated list of comment IDs for the resources that are being retrieved. In a comment resource, the id property specifies the comment's ID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Specifies the ID of the comment for which replies should be retrieved.
        /// </summary>
        /// <remarks>
        /// Note: YouTube currently supports replies only for top-level comments. However, replies to replies may be supported in the future.
        /// </remarks>
        public string ParentId { get; set; }

        /// <summary>
        /// Parameter indicates whether the API should return comments formatted as HTML or as plain text. The default value is html.
        /// </summary>
        public TextFormat? TextFormat { get; set; }
    }
}