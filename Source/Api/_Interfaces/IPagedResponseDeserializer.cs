using YoutubeSnoop.Api.Entities;

namespace YoutubeSnoop.Api
{
    public interface IPagedResponseDeserializer<TResponse>
        where TResponse : IResponse
    {
        IPagedResponse<TResponse> Deserialize(string json);
    }
}