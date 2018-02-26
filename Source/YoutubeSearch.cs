namespace YoutubeSnoop
{
    //public class YoutubeSearch : IEnumerable<YoutubeVideo>
    //{
    //    public int Buffer { get; }

    //    public SearchApiRequestSettings Settings { get; }

    //    private IList<YoutubeVideo> _videos;

    //    public YoutubeSearch(SearchApiRequestSettings settings, int buffer = 20)
    //    {
    //        Buffer = buffer;
    //        Settings = settings;
    //    }

    //    public IEnumerator<YoutubeVideo> GetEnumerator()
    //    {
    //        if (_videos == null)
    //        {
    //            var api = new SearchApiRequest(Settings);
    //            api.Response.Items.First().
    //            _videos = api.TotalItems.Select(i => new YoutubeVideo(i.Snippet)).ToList();
    //        }

    //        return _videos.GetEnumerator();
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        return GetEnumerator();
    //    }
    //}
}