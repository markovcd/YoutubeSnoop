using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.PlaylistItems;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubePlaylistItems : YoutubeCollection<YoutubePlaylistItem, PlaylistItem, PlaylistItemsApiRequestSettings>
    {
        public YoutubePlaylistItems(PlaylistItemsApiRequestSettings settings = null, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
            : base(settings, partTypes, resultsPerPage)
        {
        }
    }
}