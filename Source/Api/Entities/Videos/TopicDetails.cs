using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Videos
{
    public class TopicDetails
    {
        /// <summary>
        /// A list of Wikipedia URLs that provide a high-level description of the video's content.
        /// </summary>
        public IList<string> TopicCategories { get; set; }
    }
}