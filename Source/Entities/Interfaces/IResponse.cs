namespace YoutubeSnoop.Entities.Interfaces
{
    public interface IResponse : IResourceId
    {
        string Etag { get; }
    }
}
