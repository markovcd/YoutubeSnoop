using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Interfaces
{
    public interface IResponse
    {
        string Etag { get; }
        ResourceKind Kind { get; }
    }
}