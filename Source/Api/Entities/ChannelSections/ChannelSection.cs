using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.ChannelSections
{
    public class ChannelSection : Response
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
        public IDictionary<string, TitleDescription> Localizations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Targeting Targeting { get; set; }
    }
}
