using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Videos
{
    public class TopicDetails
    {
        public IList<string> TopicIds { get; set; }
        public IList<string> RelevantTopicIds { get; set; }
        public IList<string> TopicCategories { get; set; }
    }
}