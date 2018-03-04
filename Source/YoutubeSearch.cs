using System.Collections;
using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Entities.Search;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubeSearch : IYoutubeCollection<YoutubeSearchResult>
    {
        public IApiRequest<SearchResult> Request { get; }
        public IEnumerable<YoutubeVideo> Videos { get; }
        public IEnumerable<YoutubePlaylist> Playlists { get; }
        public IEnumerable<YoutubeChannel> Channels { get; }

        public YoutubeSearch(SearchApiRequestSettings settings, int resultsPerPage = 20)
        {
            Request = new ApiRequest<SearchResult, SearchApiRequestSettings>(settings, resultsPerPage);
            Videos = this.Where(i => i.Kind == ResourceKind.Video).Select(i => (YoutubeVideo)i.Details);
            Playlists = this.Where(i => i.Kind == ResourceKind.Playlist).Select(i => (YoutubePlaylist)i.Details);
            Channels = this.Where(i => i.Kind == ResourceKind.Channel).Select(i => (YoutubeChannel)i.Details);
        }            

        public YoutubeSearch(string query)
            : this(new SearchApiRequestSettings { Query = query }) { }

        public IEnumerator<YoutubeSearchResult> GetEnumerator()
        {
            return Request.Items.Select(i => new YoutubeSearchResult(i)).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}