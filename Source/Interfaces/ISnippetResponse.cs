namespace YoutubeSnoop.Interfaces
{
    public interface ISnippetResponse<TSnippet> : IResponse
    {
        TSnippet Snippet { get; }
    }
}
