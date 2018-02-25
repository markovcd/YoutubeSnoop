using Newtonsoft.Json;
using System.Collections.Generic;
using YoutubeSnoop.Entities.Converters;

namespace YoutubeSnoop.Entities
{
    public class VideoListResponse : Interfaces.IPagedResponse<Video>
    {
        public string NextPageToken { get; set; }
        public string PrevPageToken { get; set; }
        public PageInfo PageInfo { get; set; }
        public IList<Video> Items { get; set; }

        [JsonConverter(typeof(ResourceKindConverter))]
        public ResourceKind Kind { get; set; }
        public string Etag { get; set; }
    }
}
