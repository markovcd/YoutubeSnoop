using Newtonsoft.Json;
using YoutubeSnoop.Api.Converters;

namespace YoutubeSnoop.Enums
{
    [JsonConverter(typeof(ResourceKindConverter))]
    public enum ResourceKind
    {
        None,
        Activity,
        ActivityListResponse,

        Caption,
        CaptionListResponse,

        Channel,
        ChannelListResponse,

        ChannelSection,
        ChannelSectionListResponse,

        Comment,
        CommentListResponse,

        CommentThread,
        CommentThreadListResponse,

        GuideCategory,
        GuideCategoryListResponse,

        I18nLanguage,
        I18nLanguageListResponse,

        I18nRegion,
        I18nRegionListResponse,

        Playlist,
        PlaylistListResponse,

        PlaylistItem,
        PlaylistItemListResponse,

        SearchResult,
        SearchListResponse,

        Subscription,
        SubscriptionListResponse,

        Video,
        VideoListResponse,

        VideoCategory,
        VideoCategoryListResponse,
    }
}