using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Entities
{
    public class Resource : IResource
    {
        public ResourceKind Kind { get; set; }
    }
}
