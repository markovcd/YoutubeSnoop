using System;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Entities.Videos
{
    public class Status
    {
        public UploadStatus UploadStatus { get; set; }
        public FailureStatus FailureStatus { get; set; }
        public RejectionReason RejectionReason { get; set; }
        public PrivacyStatus PrivacyStatus { get; set; }
        public DateTime? PublishedAt { get; set; }
        public License License { get; set; }
        public bool? Embeddable { get; set; }
        public bool? PublicStatsViewable { get; set; }
    }
}