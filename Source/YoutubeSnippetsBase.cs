using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
{
    public abstract class YoutubeSnippetsBase<TSettings, TSnippet, TItem>
         where TItem : ISnippetResponse<TSnippet>
         where TSettings : IApiRequestSettings
    {
        public TSettings Settings { get; }
        public IList<TSnippet> Snippets { get; }

        protected YoutubeSnippetsBase(TSettings settings)
        {
            Settings = settings;
            var api = new ApiRequest<TItem, TSettings>(settings);
            Snippets = api.TotalItems.Select(i => i.Snippet).ToList();
        }

        protected YoutubeSnippetsBase(IEnumerable<TSnippet> snippets)
        {
            Snippets = snippets.ToList();
        }
    }
}
