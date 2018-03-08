namespace YoutubeSnoop.Api.Entities.Subscriptions
{
    public class Subscription : Response
    {
        public string Id { get; set; }
        public Snippet Snippet { get; set; }
        public ContentDetails ContentDetails { get; set; }
        public SubscriberSnippet SubscriberSnippet { get; set; }
    }
}
