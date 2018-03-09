using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Videos
{
    public class TopicDetails
    {
        /// <summary>
        /// 
        /// </summary>
        public IList<string> TopicIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IList<string> RelevantTopicIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IList<string> TopicCategories { get; set; }
    }
}