using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Playlists;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubePlaylists : YoutubeCollection<YoutubePlaylist, Playlist, PlaylistSettings>
    {
         public YoutubePlaylists(PlaylistSettings settings = null, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
            : base(settings, partTypes, resultsPerPage)
        {
        }
    }
}