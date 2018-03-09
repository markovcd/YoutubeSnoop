using System;

namespace YoutubeSnoop.Api.Entities.Comments
{
    public class Snippet
    {
        /// <summary>
        /// The display name of the user who posted the comment.
        /// </summary>
        public string AuthorDisplayName { get; set; }

        /// <summary>
        /// The URL for the avatar of the user who posted the comment.
        /// </summary>
        public string AuthorProfileImageUrl { get; set; }

        /// <summary>
        /// The URL of the comment author's YouTube channel, if available.
        /// </summary>
        public string AuthorChannelUrl { get; set; }

        /// <summary>
        /// This object encapsulates information about the comment author's YouTube channel, if available.
        /// </summary>
        public PropertyValue AuthorChannelId { get; set; }

        /// <summary>
        /// The ID of the YouTube channel associated with the comment.
        /// </summary>
        /// <remarks>
        /// If the comment is a video comment, then this property identifies the video's channel, and the snippet.videoId property identifies the video.
        /// If the comment is a channel comment, then this property identifies the channel that the comment is about.
        /// </remarks>
        public string ChannelId { get; set; }

        /// <summary>
        /// The ID of the video that the comment refers to. This property is only present if the comment was made on a video.
        /// </summary>
        public string VideoId { get; set; }

        /// <summary>
        /// The comment's text. The text can be retrieved in either plain text or HTML. (The comments.list and commentThreads.list methods both support a textFormat parameter, which specifies the desired text format.)
        /// </summary>
        /// <remarks>
        /// Note that even the plain text may differ from the original comment text. For example, it may replace video links with video titles.
        /// </remarks>
        public string TextDisplay { get; set; }

        /// <summary>
        /// The unique ID of the parent comment. This property is only set if the comment was submitted as a reply to another comment.
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// The total number of likes (positive ratings) the comment has received.
        /// </summary>
        public int? LikeCount { get; set; }

        /// <summary>
        /// The date and time when the comment was orignally published.
        /// </summary>
        public DateTime? PublishedAt { get; set; }

        /// <summary>
        /// The date and time when the comment was last updated.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }
    }
}