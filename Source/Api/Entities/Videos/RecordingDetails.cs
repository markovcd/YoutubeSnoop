using System;

namespace YoutubeSnoop.Api.Entities.Videos
{
    public class RecordingDetails
    {
        /// <summary>
        /// 
        /// </summary>
        public string LocationDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? RecordingDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Location Location { get; set; }
    }
}