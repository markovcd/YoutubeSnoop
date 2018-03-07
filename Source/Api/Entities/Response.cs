using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities
{
    public class Response : IResponse
    {
        public string Etag { get; set; }
        public ResourceKind Kind { get; set; }
    }
}
