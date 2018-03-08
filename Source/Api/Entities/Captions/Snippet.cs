using System;

namespace YoutubeSnoop.Api.Entities.Captions
{
    public class Snippet
    {
        public string VideoId { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string TrackKind { get; set; }
        public string Language { get; set; }
        public string Name { get; set; }
        public string AudioTrackType { get; set; }
        public bool? IsCC { get; set; }
        public bool? IsLarge { get; set; }
        public bool? IsEasyReader { get; set; }
        public bool? IsDraft { get; set; }
        public bool? IsAutoSynced { get; set; }
        public string Status { get; set; }
        public string FailureReason { get; set; }
    }
}
