using YoutubeSnoop.Api.Entities;

namespace YoutubeSnoop.Api
{
    public interface IResponseDeserializer<TItem>
        where TItem : IResponse
    {
        IPagedResponse<TItem> Deserialize(string json);
    }
}
