using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities
{
    public class Resource : IResource
    {
        /// <summary>
        /// Identifies the API resource's type.
        /// </summary>
        public ResourceKind Kind { get; set; }
    }
}
