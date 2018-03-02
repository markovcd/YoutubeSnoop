using System;

namespace YoutubeSnoop.Entities.Videos
{
    public class Status
    {
        public string UploadStatus { get; set; }
        public string FailureStatus { get; set; }
        public string RejectionReason { get; set; }
        public string PrivacyStatus { get; set; }
        public DateTime? PublishedAt { get; set; }
        public string License { get; set; }
        public bool? Embeddable { get; set; }
        public bool? PublicStatsViewable { get; set; }
    }
}