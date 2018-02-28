using YoutubeSnoop.Attributes;

namespace YoutubeSnoop.Enums
{
    public enum ResourceKind
    {
        None,
        /*[ApiResourceMapping(typeof(Entities.Activity))]*/     Activity,
        /*[ApiResponseMapping(typeof(Entities.Activity))]*/     ActivityListResponse,

        /*[ApiResourceMapping(typeof(Entities.Caption))]*/      Caption,
        /*[ApiResponseMapping(typeof(Entities.Caption))]*/      CaptionListResponse,

        [ApiResourceMapping(typeof(Entities.Channel))]          Channel,
        [ApiResponseMapping(typeof(Entities.Channel))]          ChannelListResponse,

        /*[ApiResourceMapping(typeof(Entities.ChannelSection))]*/ChannelSection,
        /*[ApiResponseMapping(typeof(Entities.ChannelSection))]*/ChannelSectionListResponse,

        /*[ApiResourceMapping(typeof(Entities.Comment))]*/      Comment,
        /*[ApiResponseMapping(typeof(Entities.Comment))]*/      CommentListResponse,

        /*[ApiResourceMapping(typeof(Entities.CommentThread))]*/CommentThread,
        /*[ApiResponseMapping(typeof(Entities.CommentThread))]*/CommentThreadListResponse,

        /*[ApiResourceMapping(typeof(Entities.GuideCategory))]*/GuideCategory,
        /*[ApiResponseMapping(typeof(Entities.GuideCategory))]*/GuideCategoryListResponse,

        /*[ApiResourceMapping(typeof(Entities.I18nLanguage))]*/ I18nLanguage,
        /*[ApiResponseMapping(typeof(Entities.I18nLanguage))]*/ I18nLanguageListResponse,

        /*[ApiResourceMapping(typeof(Entities.I18nRegion))]*/   I18nRegion,
        /*[ApiResponseMapping(typeof(Entities.I18nRegion))]*/   I18nRegionListResponse,

        [ApiResourceMapping(typeof(Entities.Playlist))]         Playlist,
        [ApiResponseMapping(typeof(Entities.PlaylistItem))]     PlaylistListResponse,

        [ApiResourceMapping(typeof(Entities.PlaylistItem))]     PlaylistItem,
        [ApiResponseMapping(typeof(Entities.PlaylistItem))]     PlaylistItemListResponse,

        [ApiResourceMapping(typeof(Entities.SearchResult))]     SearchResult,
        [ApiResponseMapping(typeof(Entities.SearchResult))]     SearchListResponse,

        /*[ApiResourceMapping(typeof(Entities.Subscription))]*/ Subscription,
        /*[ApiResponseMapping(typeof(Entities.Subscription))]*/ SubscriptionListResponse,

        [ApiResourceMapping(typeof(Entities.Video))]            Video,
        [ApiResponseMapping(typeof(Entities.Video))]            VideoListResponse,

        /*[ApiResourceMapping(typeof(Entities.VideoCategory))]*/VideoCategory,
        /*[ApiResponseMapping(typeof(Entities.VideoCategory))]*/VideoCategoryListResponse,
    
    }
}