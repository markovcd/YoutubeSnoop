using System;

namespace YoutubeSnoop.Api.Entities.PlaylistItems
{
    public class ContentDetails
    {
        /// <summary>
        /// The ID that YouTube uses to uniquely identify a video. To retrieve the video resource, set the id query parameter to this value in your API request.
        /// </summary>
        public string VideoId { get; set; }

        /// <summary>
        /// A user-generated note for this item. The property value has a maximum length of 280 characters.
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// The date and time that the video was published to YouTube.
        /// </summary>
        public DateTime? VideoPublishedAt { get; set; }
    }
}