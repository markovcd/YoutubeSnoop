using System.Collections.Generic;

namespace YoutubeSnoop.Entities
{
    public class ChannelTopicDetails
    {
        public IList<string> TopicIds { get; set; }
        public IList<string> TopicCategories { get; set; }
    }
}