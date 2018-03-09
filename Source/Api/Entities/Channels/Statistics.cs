namespace YoutubeSnoop.Api.Entities.Channels
{
    public class Statistics
    {
        /// <summary>
        /// The number of times the channel has been viewed.
        /// </summary>
        public long? ViewCount { get; set; }

        /// <summary>
        /// The number of comments for the channel.
        /// </summary>
        public long? CommentCount { get; set; }

        /// <summary>
        /// The number of subscribers that the channel has.
        /// </summary>
        public long? SubscriberCount { get; set; }

        /// <summary>
        /// Indicates whether the channel's subscriber count is publicly visible.
        /// </summary>
        public bool? HiddenSubscriberCount { get; set; }

        /// <summary>
        /// The number of videos uploaded to the channel.
        /// </summary>
        public long? VideoCount { get; set; }
    }
}