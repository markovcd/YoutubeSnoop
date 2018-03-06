using Newtonsoft.Json;
using YoutubeSnoop.Entities;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
{
    public class ResponseDeserializer<TItem> : IResponseDeserializer<TItem>
        where TItem : IResponse
    {
        public IPagedResponse<TItem> Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<PagedResponse<TItem>>(json);
        }
    }
}