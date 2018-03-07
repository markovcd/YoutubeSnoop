namespace YoutubeSnoop.Api.Entities.ChannelSections
{
    class ChannelSection : Response
    {
        public string Id { get; set; }
        public Snippet Snippet { get; set; }
        public ContentDetails ContentDetails { get; set; }
        public Localizations Localizations { get; set; }
        public Targeting Targeting { get; set; }
    }
}
