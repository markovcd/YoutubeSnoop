namespace YoutubeSnoop.Api.Entities.Subscriptions
{
    public class Subscription : Response
    {
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Snippet Snippet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ContentDetails ContentDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public SubscriberSnippet SubscriberSnippet { get; set; }
    }
}
