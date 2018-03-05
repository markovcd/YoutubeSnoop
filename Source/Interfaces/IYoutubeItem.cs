using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Interfaces
{
    public interface IYoutubeItem
    {
        string Id { get; }
        ResourceKind Kind { get; }
    }
}