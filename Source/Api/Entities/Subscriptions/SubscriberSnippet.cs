using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Subscriptions
{
    public class SubscriberSnippet : TitleDescription
    {
        public string ChannelId { get; set; }
        public IDictionary<string, Thumbnail> Thumbnails { get; set; }
    }
}