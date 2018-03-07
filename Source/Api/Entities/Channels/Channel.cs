using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Channels
{
    public class Channel : Response
    {
        public string Id { get; set; }

        public IDictionary<string, TitleDescription> Localizations { get; set; }
        public Snippet Snippet { get; set; }
        public ContentDetails ContentDetails { get; set; }
        public ContentOwnerDetails ContentOwnerDetails { get; set; }
        public Statistics Statistics { get; set; }
        public TopicDetails TopicDetails { get; set; }
        public Status Status { get; set; }
        public BrandingSettings BrandingSettings { get; set; }
    }
}