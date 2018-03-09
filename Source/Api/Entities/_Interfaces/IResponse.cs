using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities
{
    public interface IResponse
    {
        /// <summary>
        /// The Etag of this resource.
        /// </summary>
        string Etag { get; }

        /// <summary>
        /// Identifies the API resource's type.
        /// </summary>
        ResourceKind Kind { get; }
    }
}