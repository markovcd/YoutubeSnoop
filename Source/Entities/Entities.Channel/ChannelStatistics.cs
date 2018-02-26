namespace YoutubeSnoop.Entities
{
    public class ChannelStatistics
    {
        public long? ViewCount { get; set; }
        public long? CommentCount { get; set; }
        public long? SubscriberCount { get; set; }
        public bool? HiddenSubscriberCount { get; set; }
        public long? VideoCount { get; set; }
    }
}