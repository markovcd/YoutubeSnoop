using Newtonsoft.Json;
using YoutubeSnoop.Api.Attributes;
using YoutubeSnoop.Api.Converters;
using YoutubeSnoop.Api.Entities.Activities;
using YoutubeSnoop.Api.Entities.Channels;
using YoutubeSnoop.Api.Entities.ChannelSections;
using YoutubeSnoop.Api.Entities.Comments;
using YoutubeSnoop.Api.Entities.CommentThreads;
using YoutubeSnoop.Api.Entities.GuideCategories;
using YoutubeSnoop.Api.Entities.I18nLanguages;
using YoutubeSnoop.Api.Entities.I18nRegions;
using YoutubeSnoop.Api.Entities.PlaylistItems;
using YoutubeSnoop.Api.Entities.Playlists;
using YoutubeSnoop.Api.Entities.Search;
using YoutubeSnoop.Api.Entities.Subscriptions;
using YoutubeSnoop.Api.Entities.VideoCategories;
using YoutubeSnoop.Api.Entities.Videos;

namespace YoutubeSnoop.Enums
{
    [JsonConverter(typeof(ResourceKindConverter))]
    public enum ResourceKind
    {
        None,
        [EntityMapping(typeof(Activity))]       Activity,
        [ApiMapping(typeof(Activity))]          ActivityListResponse,

        [EntityMapping(typeof(Api.Entities.Captions.Caption))]      Caption,
        [ApiMapping(typeof(Api.Entities.Captions.Caption))]      CaptionListResponse,

        [EntityMapping(typeof(Channel))]        Channel,
        [ApiMapping(typeof(Channel))]           ChannelListResponse,

        [EntityMapping(typeof(ChannelSection))] ChannelSection,
        [ApiMapping(typeof(ChannelSection))]    ChannelSectionListResponse,

        [EntityMapping(typeof(Comment))]        Comment,
        [ApiMapping(typeof(Comment))]           CommentListResponse,

        [EntityMapping(typeof(CommentThread))]  CommentThread,
        [ApiMapping(typeof(CommentThread))]     CommentThreadListResponse,

        [EntityMapping(typeof(GuideCategory))]  GuideCategory,
        [ApiMapping(typeof(GuideCategory))]     GuideCategoryListResponse,

        [EntityMapping(typeof(I18nLanguage))]   I18nLanguage,
        [ApiMapping(typeof(I18nLanguage))]      I18nLanguageListResponse,

        [EntityMapping(typeof(I18nRegion))]     I18nRegion,
        [ApiMapping(typeof(I18nRegion))]        I18nRegionListResponse,

        [EntityMapping(typeof(Playlist))]       Playlist,
        [ApiMapping(typeof(PlaylistItem))]      PlaylistListResponse,

        [EntityMapping(typeof(PlaylistItem))]   PlaylistItem,
        [ApiMapping(typeof(PlaylistItem))]      PlaylistItemListResponse,

        [EntityMapping(typeof(SearchResult))]   SearchResult,
        [ApiMapping(typeof(SearchResult))]      SearchListResponse,

        [EntityMapping(typeof(Subscription))]   Subscription,
        [ApiMapping(typeof(Subscription))]      SubscriptionListResponse,

        [EntityMapping(typeof(Video))]          Video,
        [ApiMapping(typeof(Video))]             VideoListResponse,

        [EntityMapping(typeof(VideoCategory))]  VideoCategory,
        [ApiMapping(typeof(VideoCategory))]     VideoCategoryListResponse,
    
    }
}