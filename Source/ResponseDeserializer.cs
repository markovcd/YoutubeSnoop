using Newtonsoft.Json;
using YoutubeSnoop.Entities;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
{
    public interface IResponseDeserializer<TItem>
        where TItem : IResponse
    {
        IPagedResponse<TItem> Deserialize(string json);
    }

    public class ResponseDeserializer<TItem> : IResponseDeserializer<TItem>
        where TItem : IResponse
    {
        public IPagedResponse<TItem> Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<Response<TItem>>(json);
        }
    }
}