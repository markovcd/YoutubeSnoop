using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public interface IYoutubeItem
    {
        string Id { get; }
        ResourceKind Kind { get; }
    }
}