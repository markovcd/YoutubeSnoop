using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities
{
    public class Resource
    {
        /// <summary>
        /// Identifies the API resource's type.
        /// </summary>
        public ResourceKind Kind { get; set; }

        public string ChannelId { get; set; }
        public string PlaylistId { get; set; }
        public string VideoId { get; set; }
    }
}