using YoutubeSnoop.Entities.Playlists;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubePlaylist : YoutubeRequest<PlaylistApiRequestSettings, Playlist>, IYoutubeItem
    {
        private const string _youtubeUrl = @"https://www.youtube.com/playlist?list={0}";

        public YoutubePlaylist(string id) : this(new PlaylistApiRequestSettings { Id = id }) { }

        public YoutubePlaylist(PlaylistApiRequestSettings settings) : base(settings)
        {
            Id = Response.Id;
            Url = string.Format(_youtubeUrl, Id);
        }

        public string Url { get; }
        public string Id { get; }
    }
}