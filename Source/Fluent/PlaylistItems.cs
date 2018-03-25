using System;
using System.Linq;
using YoutubeSnoop.Api;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubePlaylistItems PlaylistItems(PlaylistItemSettings settings, params PartType[] partTypes)
        {
            return new YoutubePlaylistItems(settings, partTypes, ResultsPerPage);
        }

        public static YoutubePlaylistItems PlaylistItems(PlaylistItemSettings settings = null)
        {
            return PlaylistItems(settings, PartType.Snippet);
        }

        public static YoutubePlaylistItems PlaylistItems(string playlistId)
        {
            return PlaylistItems(new PlaylistItemSettings { PlaylistId = playlistId });
        }

        public static YoutubePlaylistItems RequestPart(this YoutubePlaylistItems playlistItems, PartType partType)
        {
            return PlaylistItems(playlistItems.Settings.Clone(), playlistItems.PartTypes.Append(partType).ToArray());
        }

        public static YoutubePlaylistItems RequestSnippet(this YoutubePlaylistItems playlistItems)
        {
            return playlistItems.RequestPart(PartType.Snippet);
        }

        public static YoutubePlaylistItems RequestContentDetails(this YoutubePlaylistItems playlistItems)
        {
            return playlistItems.RequestPart(PartType.ContentDetails);
        }

        public static YoutubePlaylistItems RequestStatus(this YoutubePlaylistItems playlistItems)
        {
            return playlistItems.RequestPart(PartType.Status);
        }

        public static YoutubePlaylistItems RequestAllParts(this YoutubePlaylistItems playlistItems)
        {
            return playlistItems.RequestContentDetails().RequestSnippet().RequestStatus();
        }

        public static YoutubeVideo Details(this YoutubePlaylistItem playlistItem)
        {
            switch (playlistItem.ItemKind)
            {
                case ResourceKind.Video: return Video(playlistItem.ItemId);
                case ResourceKind.Playlist: return null;
                case ResourceKind.Channel: return null;
                default: throw new InvalidOperationException();
            }
        }
    }
}