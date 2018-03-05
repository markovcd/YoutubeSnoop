using YoutubeSnoop.Entities.Playlists;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubePlaylists : YoutubeCollection<YoutubePlaylist, Playlist, PlaylistApiRequestSettings>
    {
        public YoutubePlaylists(IApiRequest<Playlist, PlaylistApiRequestSettings> request) : base(request) { }

        protected override YoutubePlaylist CreateItem(Playlist response)
        {
            return new YoutubePlaylist(response);
        }
    }
}