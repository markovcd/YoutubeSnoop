using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.ChannelSections
{
    public class Snippet
    {
        /// <summary>
        /// 
        /// </summary>
        public ChannelSectionType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Style { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DefaultLanguage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TitleDescription Localized { get; set; } 
    }
}