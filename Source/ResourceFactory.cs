using Newtonsoft.Json;
using YoutubeSnoop.Entities;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
{
    public static class ResourceFactory
    {
        public static TResource Deserialize<TResource>(string json) where TResource : IResource
        {
            return JsonConvert.DeserializeObject<TResource>(json);
        }

        public static Response<TItem> DeserializeResponse<TItem>(string json) where TItem : IResponse
        {
            var response = JsonConvert.DeserializeObject<Response<TItem>>(json);
            response.Json = json;
            return response;
        }
    }
}