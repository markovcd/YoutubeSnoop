using System.Linq;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
{
    public abstract class YoutubeRequest<TSettings, TSnippet, TItem> : YoutubeCollectionRequest<TSettings, TSnippet, TItem>
        where TItem : ISnippetResponse<TSnippet>
        where TSettings : IApiRequestSettings
        where TSnippet : class
    {
        public TSnippet Snippet { get; }

        protected YoutubeRequest(TSettings settings) : base(settings)
        {
            Snippet = Snippets.FirstOrDefault();
        }

        protected YoutubeRequest(TSnippet snippet) : base(new[] { snippet })
        {
            Snippet = snippet;
        }
    }
}
