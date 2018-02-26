namespace YoutubeSnoop.Interfaces
{
    public interface IResponse : IResourceId
    {
        string Etag { get; }
    }
}