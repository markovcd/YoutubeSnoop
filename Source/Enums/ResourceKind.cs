using YoutubeSnoop.Attributes;

namespace YoutubeSnoop.Enums
{
    public enum ResourceKind
    {
        None,
        Activity,
        ActivityListResponse,
        Caption,
        CaptionListResponse,
        [ApiResourceMapping(typeof(Entities.Channel))]      Channel,
        [ApiResponseMapping(typeof(Entities.Channel))]      ChannelListResponse,
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
        [ApiResourceMapping(typeof(Entities.Playlist))]     Playlist,
        [ApiResourceMapping(typeof(Entities.PlaylistItem))] PlaylistItem,
        [ApiResponseMapping(typeof(Entities.PlaylistItem))] PlaylistItemListResponse,
        [ApiResponseMapping(typeof(Entities.PlaylistItem))] PlaylistListResponse,
        [ApiResourceMapping(typeof(Entities.SearchResult))] SearchResult,
        [ApiResponseMapping(typeof(Entities.SearchResult))] SearchListResponse,
        Subscription,
        SubscriptionListResponse,
        [ApiResourceMapping(typeof(Entities.Video))]        Video,
        VideoCategory,
        videoCategoryListResponse,
        [ApiResponseMapping(typeof(Entities.Video))]        VideoListResponse,       
    }
}