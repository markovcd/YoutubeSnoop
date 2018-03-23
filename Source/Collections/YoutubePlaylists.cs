using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Playlists;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubePlaylists : YoutubeCollection<YoutubePlaylist, Playlist, PlaylistApiRequestSettings>
    {
        public YoutubePlaylists(IApiRequest<Playlist, PlaylistApiRequestSettings> request) : base(request)
        {
        }

        public YoutubePlaylists(PlaylistApiRequestSettings settings = null, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
            : base(settings, partTypes, resultsPerPage)
        {
        }
    }
}