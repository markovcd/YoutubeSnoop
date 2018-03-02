using YoutubeSnoop.Entities.Search;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubeSearchResult : IYoutubeItem<Snippet>
    {
        public Snippet Snippet { get; }


        public YoutubeSearchResult(Snippet snippet)
        {
            Snippet = snippet;
        }
    }
}