using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Videos
{
    public class Video : Response
    {
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Snippet Snippet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ContentDetails ContentDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Statistics Statistics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IDictionary<string, TitleDescription> Localizations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Player Player { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TopicDetails TopicDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public RecordingDetails RecordingDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public FileDetails FileDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ProcessingDetails ProcessingDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Suggestions Suggestions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public LiveStreamingDetails LiveStreamingDetails { get; set; }
    }
}