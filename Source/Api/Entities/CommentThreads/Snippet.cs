using YoutubeSnoop.Api.Entities.Comments;

namespace YoutubeSnoop.Api.Entities.CommentThreads
{
    public class Snippet
    {
        /// <summary>
        /// The YouTube channel that is associated with the comments in the thread. (The snippet.videoId property identifies the video.)
        /// </summary>
        /// <remarks>
        /// If the comments are about a video, then the value identifies the channel that uploaded the video. (The snippet.videoId property identifies the video.)
        /// If the comments refer to the channel itself, the snippet.videoId property will not have a value.
        /// </remarks>
        public string ChannelId { get; set; }

        /// <summary>
        /// The ID of the video that the comments refer to, if any. If this property is not present or does not have a value, then the thread applies to the channel and not to a specific video.
        /// </summary>
        public string VideoId { get; set; }

        /// <summary>
        /// The thread's top-level comment. The property's value is a comment resource.
        /// </summary>
        public Comment TopLevelComment { get; set; }

        /// <summary>
        /// The total number of replies that have been submitted in response to the top-level comment.
        /// </summary>
        public int? TotalReplyCount { get; set; }
    }
}