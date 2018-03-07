using System;

namespace YoutubeSnoop.Api.Entities.Videos
{
    public class LiveStreamingDetails
    {
        public DateTime? ActualStartTime { get; set; }
        public DateTime? ActualEndTime { get; set; }
        public DateTime? ScheduledStartTime { get; set; }
        public DateTime? ScheduledEndTime { get; set; }
        public long? ConcurrentViewers { get; set; }
        public long? ActiveLiveChatId { get; set; }
    }
}