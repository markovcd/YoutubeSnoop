using System.Collections.Generic;

namespace YoutubeSnoop.Entities.Videos
{
    public class TopicDetails
    {
        public IList<string> TopicIds { get; set; }
        public IList<string> RelevantTopicIds { get; set; }
        public IList<string> TopicCategories { get; set; }
    }
}