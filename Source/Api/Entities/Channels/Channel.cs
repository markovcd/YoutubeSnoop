using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Channels
{
    public class Channel : Response
    {
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IDictionary<string, TitleDescription> Localizations { get; set; }

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
        public ContentOwnerDetails ContentOwnerDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Statistics Statistics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TopicDetails TopicDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public BrandingSettings BrandingSettings { get; set; }
    }
}