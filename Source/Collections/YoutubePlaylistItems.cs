using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.PlaylistItems;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubePlaylistItems : YoutubeCollection<YoutubePlaylistItem, PlaylistItem, PlaylistItemSettings>
    {
        public YoutubePlaylistItems(PlaylistItemSettings settings = null, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
            : base(settings, partTypes, resultsPerPage)
        {
        }
    }
}