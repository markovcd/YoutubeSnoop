using System.Collections.Generic;
using Newtonsoft.Json;
using YoutubeSnoop.Entities.Converters;

namespace YoutubeSnoop.Entities
{
    public class PlaylistItemListResponse : Interfaces.IPagedResponse<PlaylistItem>
    {
        public string NextPageToken { get; set; }
        public string PrevPageToken { get; set; }
        public PageInfo PageInfo { get; set; }
        public IList<PlaylistItem> Items { get; set; }

        [JsonConverter(typeof(ResourceKindConverter))]
        public ResourceKind Kind { get; set; }
        public string Etag { get; set; }
    }
}
