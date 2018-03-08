using YoutubeSnoop.Api.Entities.Comments;

namespace YoutubeSnoop.Api.Entities.CommentThreads
{
    public class Snippet
    {
        public string ChannelId { get; set; }
        public string VideoId { get; set; }
        public Comment TopLevelComment { get; set; }
        public int? TotalReplyCount { get; set; }
    }
}