using YoutubeSnoop.Api.Entities.PlaylistItems;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubePlaylistItems PlaylistItems(PlaylistItemsApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<PlaylistItem, PlaylistItemsApiRequestSettings>(settings, partTypes);
            return new YoutubePlaylistItems(request);
        }

        public static YoutubePlaylistItems PlaylistItems(PlaylistItemsApiRequestSettings settings = null)
        {
            return PlaylistItems(settings ?? new PlaylistItemsApiRequestSettings(), PartType.Snippet);
        }

        public static YoutubePlaylistItems PlaylistItems(string playlistId)
        {
            return PlaylistItems(new PlaylistItemsApiRequestSettings { PlaylistId = playlistId });
        }

        public static YoutubePlaylistItems RequestPart(this YoutubePlaylistItems playlistItems, PartType partType)
        {
            var request = playlistItems.Request.RequestPart(partType);
            return new YoutubePlaylistItems(request);
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

        public static IYoutubeItem Details(this YoutubePlaylistItem playlistItem)
        {
            return playlistItem.Item.Snippet?.ResourceId?.Details();
        }

        public static TItem Details<TItem>(this YoutubePlaylistItem playlistItem) where TItem : class, IYoutubeItem
        {
            return Details(playlistItem) as TItem;
        }
    }
}