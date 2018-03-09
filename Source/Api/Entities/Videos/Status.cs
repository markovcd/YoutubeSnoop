using System;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.Videos
{
    public class Status
    {
        /// <summary>
        /// 
        /// </summary>
        public UploadStatus? UploadStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public FailureStatus? FailureStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public RejectionReason? RejectionReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PrivacyStatus? PrivacyStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? PublishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public License? License { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool? Embeddable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool? PublicStatsViewable { get; set; }
    }
}