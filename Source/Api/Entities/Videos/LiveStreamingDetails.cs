using System;

namespace YoutubeSnoop.Api.Entities.Videos
{
    public class LiveStreamingDetails
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ActualStartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? ActualEndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? ScheduledStartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? ScheduledEndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long? ConcurrentViewers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long? ActiveLiveChatId { get; set; }
    }
}