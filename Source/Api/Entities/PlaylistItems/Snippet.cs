using System;
using System.Collections.Generic;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.PlaylistItems
{
    public class Snippet : TitleDescription
    {
        /// <summary>
        /// The date and time that the item was added to the playlist. 
        /// </summary>
        public DateTime? PublishedAt { get; set; }

        /// <summary>
        /// The ID that YouTube uses to uniquely identify the user that added the item to the playlist.
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// The channel title of the channel that the playlist item belongs to.
        /// </summary>
        public string ChannelTitle { get; set; }

        /// <summary>
        /// The ID that YouTube uses to uniquely identify the playlist that the playlist item is in.
        /// </summary>
        public string PlaylistId { get; set; }

        /// <summary>
        /// The order in which the item appears in the playlist. The value uses a zero-based index, so the first item has a position of 0, the second item has a position of 1, and so forth.
        /// </summary>
        public int? Position { get; set; }

        /// <summary>
        /// A map of thumbnail images associated with the playlist item. For each object in the map, the key is the name of the thumbnail image, and the value is an object that contains other information about the thumbnail.
        /// </summary>
        public IDictionary<ThumbnailSize, Thumbnail> Thumbnails { get; set; }

        /// <summary>
        /// The id object contains information that can be used to uniquely identify the resource that is included in the playlist as the playlist item.
        /// </summary>
        public IResource ResourceId { get; set; }
    }
}