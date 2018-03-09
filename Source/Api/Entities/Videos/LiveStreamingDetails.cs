using System;

namespace YoutubeSnoop.Api.Entities.Videos
{
    public class LiveStreamingDetails
    {
        /// <summary>
        /// The time that the broadcast actually started. 
        /// </summary>
        public DateTime? ActualStartTime { get; set; }

        /// <summary>
        /// The time that the broadcast actually ended.
        /// </summary>
        public DateTime? ActualEndTime { get; set; }

        /// <summary>
        /// The time that the broadcast is scheduled to begin. 
        /// </summary>
        public DateTime? ScheduledStartTime { get; set; }

        /// <summary>
        /// The time that the broadcast is scheduled to end. 
        /// </summary>
        public DateTime? ScheduledEndTime { get; set; }

        /// <summary>
        /// The number of viewers currently watching the broadcast. The property and its value will be present if the broadcast has current viewers and the broadcast owner has not hidden the viewcount for the video. Note that YouTube stops tracking the number of concurrent viewers for a broadcast when the broadcast ends. So, this property would not identify the number of viewers watching an archived video of a live broadcast that already ended.
        /// </summary>
        public long? ConcurrentViewers { get; set; }

        /// <summary>
        /// The ID of the currently active live chat attached to this video. This field is filled only if the video is a currently live broadcast that has live chat. Once the broadcast transitions to complete this field will be removed and the live chat closed down. For persistent broadcasts that live chat id will no longer be tied to this video but rather to the new video being displayed at the persistent page.
        /// </summary>
        public long? ActiveLiveChatId { get; set; }
    }
}