using Newtonsoft.Json;
using YoutubeSnoop.Api.Entities;

namespace YoutubeSnoop.Api
{
    /// <summary>
    /// Default JSON deserializer. Use this in the constructor of ApiRequest class.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    public class PagedResponseDeserializer<TItem> : IPagedResponseDeserializer<TItem>
        where TItem : IResponse
    {
        public IPagedResponse<TItem> Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<PagedResponse<TItem>>(json);
        }
    }
}