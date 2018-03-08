using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.ChannelSections
{
    public class Snippet
    {
        public ChannelSectionType? Type { get; set; } 
        public string Style { get; set; } 
        public string ChannelId { get; set; } 
        public string Title { get; set; } 
        public int Position { get; set; } 
        public string DefaultLanguage { get; set; } 
        public TitleDescription Localized { get; set; } 
    }
}