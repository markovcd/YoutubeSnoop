using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Entities.I18Languages
{
    public class I18nLanguage : IResponse
    {
        public string Etag { get; set; }

        public ResourceKind Kind { get; set; }

        public string Id { get; set; }

        public Snippet Snippet { get; set; }
    }
}
