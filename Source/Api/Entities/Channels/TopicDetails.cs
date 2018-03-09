using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Channels
{
    public class TopicDetails
    {
        /// <summary>
        /// A list of Wikipedia URLs that describe the channel's content.
        /// </summary>
        public IList<string> TopicCategories { get; set; }
    }
}