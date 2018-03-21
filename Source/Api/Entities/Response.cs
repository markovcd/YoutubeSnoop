using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities
{
    public class Response : IResponse
    {
        /// <summary>
        /// The Etag of this resource.
        /// </summary>
        public string Etag { get; set; }

        /// <summary>
        /// Identifies the API resource's type.
        /// </summary>
        public ResourceKind Kind { get; set; }
    }
}