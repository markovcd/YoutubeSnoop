using YoutubeSnoop.Api.Entities;

namespace YoutubeSnoop.Api
{
    public interface IPagedResponseDeserializer<TItem>
        where TItem : IResponse
    {
        IPagedResponse<TItem> Deserialize(string json);
    }
}