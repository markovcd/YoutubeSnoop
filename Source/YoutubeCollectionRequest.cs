using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
{
    public abstract class YoutubeCollectionRequest<TSettings, TSnippet, TItem>
         where TItem : ISnippetResponse<TSnippet>
         where TSettings : IApiRequestSettings
    {
        public TSettings Settings { get; }
        public IList<TSnippet> Snippets { get; }

        protected YoutubeCollectionRequest(TSettings settings)
        {
            Settings = settings;
            var api = new ApiRequest<TItem, TSettings>(settings);
            Snippets = api.TotalItems.Select(i => i.Snippet).ToList();
        }

        protected YoutubeCollectionRequest(IEnumerable<TSnippet> snippets)
        {
            Snippets = snippets.ToList();
        }
    }
}
