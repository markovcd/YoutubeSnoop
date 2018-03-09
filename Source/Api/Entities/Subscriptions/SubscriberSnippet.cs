using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Subscriptions
{
    public class SubscriberSnippet : TitleDescription
    {
        /// <summary>
        /// 
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IDictionary<string, Thumbnail> Thumbnails { get; set; }
    }
}