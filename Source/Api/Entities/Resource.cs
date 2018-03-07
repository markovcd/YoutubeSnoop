using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities
{
    public class Resource : IResource
    {
        public ResourceKind Kind { get; set; }
    }
}
