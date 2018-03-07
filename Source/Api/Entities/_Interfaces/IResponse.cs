using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities
{
    public interface IResponse
    {
        string Etag { get; }
        ResourceKind Kind { get; }
    }
}