namespace YoutubeSnoop.Api.Entities.Channels
{
    public class Statistics
    {
        public long? ViewCount { get; set; }
        public long? CommentCount { get; set; }
        public long? SubscriberCount { get; set; }
        public bool? HiddenSubscriberCount { get; set; }
        public long? VideoCount { get; set; }
    }
}