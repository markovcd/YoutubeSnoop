using System;

namespace YoutubeSnoop.Api.Entities.Captions
{
    public class Snippet
    {
        /// <summary>
        /// 
        /// </summary>
        public string VideoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TrackKind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string AudioTrackType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool? IsCC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public bool? IsLarge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool? IsEasyReader { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool? IsDraft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool? IsAutoSynced { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FailureReason { get; set; }
    }
}
