namespace YoutubeSnoop.Interfaces
{
    public interface IResponse : IResource
    {
        string Etag { get; }
    }
}