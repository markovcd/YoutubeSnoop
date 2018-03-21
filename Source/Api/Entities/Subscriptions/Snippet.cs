using System;
using System.Collections.Generic;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.Subscriptions
{
    public class Snippet : TitleDescription
    {
        /// <summary>
        /// The date and time that the subscription was created.
        /// </summary>
        public DateTime? PublishedAt { get; set; }

        /// <summary>
        /// The title of the channel that the subscription belongs to.
        /// </summary>
        public string ChannelTitle { get; set; }

        /// <summary>
        /// The id object contains information about the channel that the user subscribed to.
        /// </summary>
        public Resource ResourceId { get; set; }

        /// <summary>
        /// The ID that YouTube uses to uniquely identify the subscriber's channel. The resource_id object identifies the channel that the user subscribed to.
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// A map of thumbnail images associated with the subscription. For each object in the map, the key is the name of the thumbnail image, and the value is an object that contains other information about the thumbnail.
        /// </summary>
        public IDictionary<ThumbnailSize, Thumbnail> Thumbnails { get; set; }
    }
}