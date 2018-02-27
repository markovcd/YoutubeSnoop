using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Interfaces
{
    public interface IResource
    {
        ResourceKind Kind { get; }
    }
}