namespace YoutubeSnoop.Interfaces
{
    public interface IResponseDeserializer<TItem>
        where TItem : IResponse
    {
        IPagedResponse<TItem> Deserialize(string json);
    }
}
