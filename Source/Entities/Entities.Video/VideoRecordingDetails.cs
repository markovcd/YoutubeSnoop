using System;

namespace YoutubeSnoop.Entities
{
    public class VideoRecordingDetails
    {
        public string LocationDescription { get; set; }
        public DateTime? RecordingDate { get; set; }
        public Location Location { get; set; }
    }

    
}