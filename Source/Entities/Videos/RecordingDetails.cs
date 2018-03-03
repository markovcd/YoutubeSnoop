using System;

namespace YoutubeSnoop.Entities.Videos
{
    public class RecordingDetails
    {
        public string LocationDescription { get; set; }
        public DateTime? RecordingDate { get; set; }
        public Location Location { get; set; }
    }
}