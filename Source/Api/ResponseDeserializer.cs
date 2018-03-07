using Newtonsoft.Json;
using YoutubeSnoop.Api.Entities;

namespace YoutubeSnoop.Api
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