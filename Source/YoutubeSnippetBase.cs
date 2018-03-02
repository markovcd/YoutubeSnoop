using System.Linq;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
{
    public abstract class YoutubeSnippetBase<TSettings, TSnippet, TItem>
        where TItem : ISnippetResponse<TSnippet>
        where TSettings : IApiRequestSettings
    {
        public TSettings Settings { get; }
        public TSnippet Snippet { get; }

        protected YoutubeSnippetBase(TSettings settings)
        {
            Settings = settings;
            var api = new ApiRequest<TItem, TSettings>(settings);
            Snippet = api.Response.Items.First().Snippet; // TODO: error handling
        }

        protected YoutubeSnippetBase(TSnippet snippet)
        {
            Snippet = snippet;
        }
    }
}
