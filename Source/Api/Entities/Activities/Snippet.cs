using System;
using System.Collections.Generic;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.Activities
{
    public class Snippet
    {
        /// <summary>
        /// The date and time that the activity occurred.
        /// </summary>
        public DateTime? PublishedAt { get; set; }

        /// <summary>
        /// The ID that YouTube uses to uniquely identify the channel associated with the activity.
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// The title of the resource primarily associated with the activity.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The description of the resource primarily associated with the activity.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// A map of thumbnail images associated with the resource that is primarily associated with the activity. For each object in the map, the key is the name of the thumbnail image, and the value is an object that contains other information about the thumbnail.
        /// </summary>
        public IDictionary<ThumbnailSize, Thumbnail> Thumbnails { get; set; }

        /// <summary>
        /// Channel title for the channel responsible for this activity.
        /// </summary>
        public string ChannelTitle { get; set; }

        /// <summary>
        /// The type of activity that the resource describes.
        /// </summary>
        public ActivityType? Type { get; set; }

        /// <summary>
        /// The group ID associated with the activity. A group ID identifies user events that are associated with the same user and resource. For example, if a user rates a video and marks the same video as a favorite, the entries for those events would have the same group ID in the user's activity feed. In your user interface, you can avoid repetition by grouping events with the same groupId value.
        /// </summary>
        public string GroupId { get; set; }
    }
}