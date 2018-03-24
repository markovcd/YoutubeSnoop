using System;
using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Api.Entities.Activities;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeActivity : YoutubeItem<Activity, ActivitySettings>, IYoutubeItem
    {
        private string _id;
        public string Id => Set(ref _id);

        private ResourceKind _kind;
        public ResourceKind Kind => Set(ref _kind);

        private string _title;
        public string Title => Set(ref _title);

        private string _description;
        public string Description => Set(ref _description);

        private DateTime _publishedAt;
        public DateTime PublishedAt => Set(ref _publishedAt);

        private IReadOnlyDictionary<ThumbnailSize, Thumbnail> _thumbnails;
        public IReadOnlyDictionary<ThumbnailSize, Thumbnail> Thumbnails => Set(ref _thumbnails);

        private string _channelId;
        public string ChannelId => Set(ref _channelId);

        private string _channelTitle;
        public string ChannelTitle => Set(ref _channelTitle);

        private string _groupId;
        public string GroupId => Set(ref _groupId);

        private ActivityType _type;
        public ActivityType Type => Set(ref _type);

        private Resource _resourceId;
        public Resource ResourceId => Set(ref _resourceId);

        private Resource _seedResourceId;
        public Resource SeedResourceId => Set(ref _seedResourceId);

        private string _playlistId;
        public string PlaylistId => Set(ref _playlistId);

        private string _playlistItemId;
        public string PlaylistItemId => Set(ref _playlistItemId);

        private RecommendationReason _recommendationReason;
        public RecommendationReason RecommendationReason => Set(ref _recommendationReason);

        private string _socialAuthor;
        public string SocialAuthor => Set(ref _socialAuthor);

        private string _socialAuthorImageUrl;
        public string SocialAuthorImageUrl => Set(ref _socialAuthorImageUrl);

        private string _socialReferenceUrl;
        public string SocialReferenceUrl => Set(ref _socialReferenceUrl);

        private SocialType _socialType;
        public SocialType SocialType => Set(ref _socialType);

        public YoutubeActivity(Activity response) : base(response)
        {
        }

        public YoutubeActivity(ActivitySettings settings = null, IEnumerable<PartType> partTypes = null) : base(settings, partTypes)
        {
        }

        protected override void SetProperties(Activity response)
        {
            if (response == null) return;

            _id = response.Id;
            _kind = response.Kind;

            if (response.Snippet != null)
            {
                _title = response.Snippet.Title;
                _description = response.Snippet.Description;
                _publishedAt = response.Snippet.PublishedAt.GetValueOrDefault();
                _thumbnails = response.Snippet.Thumbnails?.Clone();
                _channelId = response.Snippet.ChannelId;
                _channelTitle = response.Snippet.ChannelTitle;
                _groupId = response.Snippet.GroupId;
                _type = response.Snippet.Type.GetValueOrDefault();
            }

            if (response.ContentDetails != null && _type != ActivityType.None)
            {
                switch (_type)
                {
                    case ActivityType.Bulletin:
                        _resourceId = response.ContentDetails.Bulletin.ResourceId;
                        break;

                    case ActivityType.ChannelItem:
                        _resourceId = response.ContentDetails.ChannelItem.ResourceId;
                        break;

                    case ActivityType.Comment:
                        _resourceId = response.ContentDetails.Comment.ResourceId;
                        break;

                    case ActivityType.Favorite:
                        _resourceId = response.ContentDetails.Favorite.ResourceId;
                        break;

                    case ActivityType.Like:
                        _resourceId = response.ContentDetails.Like.ResourceId;
                        break;

                    case ActivityType.PlaylistItem:
                        _resourceId = response.ContentDetails.PlaylistItem.ResourceId;
                        _playlistId = response.ContentDetails.PlaylistItem.PlaylistId;
                        _playlistItemId = response.ContentDetails.PlaylistItem.PlaylistItemId;
                        break;

                    case ActivityType.Recommendation:
                        _resourceId = response.ContentDetails.Recommendation.ResourceId;
                        _seedResourceId = response.ContentDetails.Recommendation.SeedResourceId;
                        _recommendationReason = response.ContentDetails.Recommendation.Reason.GetValueOrDefault();
                        break;

                    case ActivityType.Social:
                        _resourceId = response.ContentDetails.Social.ResourceId;
                        _socialAuthor = response.ContentDetails.Social.Author;
                        _socialAuthorImageUrl = response.ContentDetails.Social.ImageUrl;
                        _socialReferenceUrl = response.ContentDetails.Social.ReferenceUrl;
                        _socialType = response.ContentDetails.Social.Type.GetValueOrDefault();
                        break;

                    case ActivityType.Subscription:
                        _resourceId = response.ContentDetails.Subscription.ResourceId;
                        break;

                    case ActivityType.Upload:
                        _resourceId = new Resource { Kind = ResourceKind.Video, VideoId = response.ContentDetails.Upload.VideoId };
                        break;

                    default: throw new InvalidOperationException();
                }
            }
        }
    }
}