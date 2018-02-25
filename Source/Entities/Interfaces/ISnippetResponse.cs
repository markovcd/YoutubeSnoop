namespace YoutubeSnoop.Entities.Interfaces
{
    public interface ISnippetResponse : IResponse
    {
        Snippet Snippet { get; }
    }
}
