using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Entities.Channels
{
    public class Status
    {
        public PrivacyStatus PrivacyStatus { get; set; }
        public bool? IsLinked { get; set; }
        public string LongUploadStatus { get; set; }
    }
}