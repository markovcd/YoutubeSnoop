using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YoutubeSnoop.Entities.PlaylistItems;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {

        public static YoutubePlaylistItems PlaylistItems(PlaylistItemsApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<PlaylistItem, PlaylistItemsApiRequestSettings>(settings, partTypes);
            return new YoutubePlaylistItems(request);
        }

        public static YoutubePlaylistItems PlaylistItems(PlaylistItemsApiRequestSettings settings)
        {
            return PlaylistItems(settings, PartType.Snippet);
        }

        public static YoutubePlaylistItems PlaylistItems()
        {
            return PlaylistItems(new PlaylistItemsApiRequestSettings(), PartType.Snippet);
        }

        public static YoutubePlaylistItems PlaylistId(this YoutubePlaylistItems playlistItems, string id)
        {
            var request = playlistItems.Request.Clone();
            request.Settings.PlaylistId = id;
            return new YoutubePlaylistItems(request);
        }

        public static IYoutubeItem Details(this YoutubePlaylistItem playlistItem)
        {
            return playlistItem.Item.Snippet.ResourceId.Details();
        }

        public static YoutubeVideos Videos(this YoutubePlaylistItems playlistItems)
        {
            return Videos(playlistItems.Select(i => i.Id));
        }
    }
}
