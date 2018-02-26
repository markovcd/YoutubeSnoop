using System.Collections.Generic;

namespace YoutubeSnoop.Entities
{
    public class VideoTopicDetails
    {
        public IList<string> TopicIds { get; set; }
        public IList<string> RelevantTopicIds { get; set; }
        public IList<string> TopicCategories { get; set; }
    }
}