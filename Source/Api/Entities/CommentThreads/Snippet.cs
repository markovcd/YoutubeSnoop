using YoutubeSnoop.Api.Entities.Comments;

namespace YoutubeSnoop.Api.Entities.CommentThreads
{
    public class Snippet
    {
        /// <summary>
        /// 
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string VideoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Comment TopLevelComment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? TotalReplyCount { get; set; }
    }
}