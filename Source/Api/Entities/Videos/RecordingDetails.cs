using System;

namespace YoutubeSnoop.Api.Entities.Videos
{
    public class RecordingDetails
    {
        /// <summary>
        /// The date and time when the video was recorded.
        /// </summary>
        public DateTime? RecordingDate { get; set; }

        /// <summary>
        /// The geolocation information associated with the video. Note that the child property values identify the location that the video owner wants to associate with the video. The value is editable, searchable on public videos, and might be displayed to users for public videos.
        /// </summary>
        public Location Location { get; set; }
    }
}