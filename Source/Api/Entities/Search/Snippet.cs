using System;
using System.Collections.Generic;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.Search
{
    public class Snippet : TitleDescription
    {
        /// <summary>
        /// The creation date and time of the resource that the search result identifies.
        /// </summary>
        public DateTime? PublishedAt { get; set; }

        /// <summary>
        /// The value that YouTube uses to uniquely identify the channel that published the resource that the search result identifies.
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// The title of the channel that published the resource that the search result identifies.
        /// </summary>
        public string ChannelTitle { get; set; }

        /// <summary>
        /// An indication of whether a video or channel resource has live broadcast content.
        /// </summary>
        /// <remarks>
        /// For a video resource, a value of upcoming indicates that the video is a live broadcast that has not yet started, while a value of live indicates that the video is an active live broadcast. For a channel resource, a value of upcoming indicates that the channel has a scheduled broadcast that has not yet started, while a value of live indicates that the channel has an active live broadcast.
        /// </remarks>
        public LiveBroadcastContent? LiveBroadcastContent { get; set; }

        /// <summary>
        /// A map of thumbnail images associated with the search result. For each object in the map, the key is the name of the thumbnail image, and the value is an object that contains other information about the thumbnail.
        /// </summary>
        public IDictionary<ThumbnailSize, Thumbnail> Thumbnails { get; set; }
    }
}