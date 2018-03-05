using YoutubeSnoop.Attributes;
using YoutubeSnoop.Entities.Channels;
using YoutubeSnoop.Entities.I18nLanguages;
using YoutubeSnoop.Entities.I18nRegions;
using YoutubeSnoop.Entities.PlaylistItems;
using YoutubeSnoop.Entities.Playlists;
using YoutubeSnoop.Entities.Search;
using YoutubeSnoop.Entities.Videos;

namespace YoutubeSnoop.Enums
{
    public enum ResourceKind
    {
        None,
        /*[ApiResourceMapping(typeof(Activity))]*/     Activity,
        /*[ApiResponseMapping(typeof(Activity))]*/     ActivityListResponse,

        /*[ApiResourceMapping(typeof(Caption))]*/      Caption,
        /*[ApiResponseMapping(typeof(Caption))]*/      CaptionListResponse,

        [ApiResourceMapping(typeof(Channel))]          Channel,
        [ApiResponseMapping(typeof(Channel))]          ChannelListResponse,

        /*[ApiResourceMapping(typeof(ChannelSection))]*/ChannelSection,
        /*[ApiResponseMapping(typeof(ChannelSection))]*/ChannelSectionListResponse,

        /*[ApiResourceMapping(typeof(Comment))]*/      Comment,
        /*[ApiResponseMapping(typeof(Comment))]*/      CommentListResponse,

        /*[ApiResourceMapping(typeof(CommentThread))]*/CommentThread,
        /*[ApiResponseMapping(typeof(CommentThread))]*/CommentThreadListResponse,

        /*[ApiResourceMapping(typeof(GuideCategory))]*/GuideCategory,
        /*[ApiResponseMapping(typeof(GuideCategory))]*/GuideCategoryListResponse,

        [ApiResourceMapping(typeof(I18nLanguage))]     I18nLanguage,
        [ApiResponseMapping(typeof(I18nLanguage))]     I18nLanguageListResponse,

        [ApiResourceMapping(typeof(I18nRegion))]       I18nRegion,
        [ApiResponseMapping(typeof(I18nRegion))]       I18nRegionListResponse,

        [ApiResourceMapping(typeof(Playlist))]         Playlist,
        [ApiResponseMapping(typeof(PlaylistItem))]     PlaylistListResponse,

        [ApiResourceMapping(typeof(PlaylistItem))]     PlaylistItem,
        [ApiResponseMapping(typeof(PlaylistItem))]     PlaylistItemListResponse,

        [ApiResourceMapping(typeof(SearchResult))]     SearchResult,
        [ApiResponseMapping(typeof(SearchResult))]     SearchListResponse,

        /*[ApiResourceMapping(typeof(Subscription))]*/ Subscription,
        /*[ApiResponseMapping(typeof(Subscription))]*/ SubscriptionListResponse,

        [ApiResourceMapping(typeof(Video))]            Video,
        [ApiResponseMapping(typeof(Video))]            VideoListResponse,

        /*[ApiResourceMapping(typeof(VideoCategory))]*/VideoCategory,
        /*[ApiResponseMapping(typeof(VideoCategory))]*/VideoCategoryListResponse,
    
    }
}