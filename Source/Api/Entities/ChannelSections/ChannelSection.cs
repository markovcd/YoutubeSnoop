using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.ChannelSections
{
    public class ChannelSection : Response
    {
        public string Id { get; set; }
        public Snippet Snippet { get; set; }
        public ContentDetails ContentDetails { get; set; }
        public IDictionary<string, TitleDescription> Localizations { get; set; }
        public Targeting Targeting { get; set; }
    }
}
