namespace YoutubeSnoop
{
    //public class YoutubePlaylist : IEnumerable<YoutubeVideo>
    //{
    //    public int Buffer { get; }

    //    public PlaylistApiRequestSettings Settings { get; }

    //    private IList<YoutubeVideo> _videos;

    //    public YoutubePlaylist(string playlistId, int buffer = 20)
    //        : this(new PlaylistApiRequestSettings { PlaylistId = playlistId}, buffer) { }

    //    public YoutubePlaylist( PlaylistApiRequestSettings settings, int buffer = 20)
    //    {
    //        Buffer = buffer;
    //        Settings = settings;
    //    }

    //    public IEnumerator<YoutubeVideo> GetEnumerator()
    //    {
    //        if (_videos == null)
    //        {
    //            var api = new PlaylistApiRequest(Settings);
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