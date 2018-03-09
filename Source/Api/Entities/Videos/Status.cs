using System;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.Videos
{
    public class Status
    {
        /// <summary>
        /// The status of the uploaded video.
        /// </summary>
        public UploadStatus? UploadStatus { get; set; }

        /// <summary>
        /// This value explains why a video failed to upload. This property is only present if the uploadStatus property indicates that the upload failed.
        /// </summary>
        public FailureStatus? FailureStatus { get; set; }

        /// <summary>
        /// This value explains why YouTube rejected an uploaded video. This property is only present if the uploadStatus property indicates that the upload was rejected.
        /// </summary>
        public RejectionReason? RejectionReason { get; set; }

        /// <summary>
        /// The video's privacy status.
        /// </summary>
        public PrivacyStatus? PrivacyStatus { get; set; }

        /// <summary>
        /// The date and time when the video is scheduled to publish. It can be set only if the privacy status of the video is private. 
        /// </summary>
        /// <remarks>
        /// Note the following two additional points about this property's behavior:
        /// If you set this property's value when calling the videos.update method, you must also set the status.privacyStatus property value to private even if the video is already private.
        /// If your request schedules a video to be published at some time in the past, the video will be published right away.As such, the effect of setting the status.publishAt property to a past date and time is the same as of changing the video's privacyStatus from private to public.
        /// </remarks>
        public DateTime? PublishAt { get; set; }

        /// <summary>
        /// The video's license.
        /// </summary>
        public License? License { get; set; }

        /// <summary>
        /// This value indicates whether the video can be embedded on another website.
        /// </summary>
        public bool? Embeddable { get; set; }

        /// <summary>
        /// This value indicates whether the extended video statistics on the video's watch page are publicly viewable. By default, those statistics are viewable, and statistics like a video's viewcount and ratings will still be publicly visible even if this property's value is set to false.
        /// </summary>
        public bool? PublicStatsViewable { get; set; }
    }
}