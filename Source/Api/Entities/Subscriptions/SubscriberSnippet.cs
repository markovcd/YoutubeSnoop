using System.Collections.Generic;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.Subscriptions
{
    public class SubscriberSnippet : TitleDescription
    {
        /// <summary>
        /// The ID that YouTube assigns to uniquely identify the subscriber's channel.
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// Thumbnail images for the subscriber's channel.
        /// </summary>
        public IDictionary<ThumbnailSize, Thumbnail> Thumbnails { get; set; }
    }
}