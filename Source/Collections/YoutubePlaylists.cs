using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Playlists;
using YoutubeSnoop.Api.Settings;

namespace YoutubeSnoop
{
    public sealed class YoutubePlaylists : YoutubeCollection<YoutubePlaylist, Playlist, PlaylistApiRequestSettings>
    {
        public YoutubePlaylists(IApiRequest<Playlist, PlaylistApiRequestSettings> request) : base(request)
        {
        }
    }
}