using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.Channels
{
    public class Status
    {
        /// <summary>
        /// 
        /// </summary>
        public PrivacyStatus? PrivacyStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool? IsLinked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string LongUploadStatus { get; set; }
    }
}