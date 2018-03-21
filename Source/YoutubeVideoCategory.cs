using YoutubeSnoop.Enums;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Api.Entities.VideoCategories;
using YoutubeSnoop.Api;

namespace YoutubeSnoop
{
    public sealed class YoutubeVideoCategory : YoutubeItem<VideoCategory, VideoCategoryApiRequestSettings>, IYoutubeItem
    {
        private string _id;
        private VideoCategory _item;
        private ResourceKind _kind;
        private string _channelId;
        private string _title;
        private bool _assignable;

        public VideoCategory Item => Set(ref _item);
        public string Id => Set(ref _id);
        public ResourceKind Kind => Set(ref _kind);
        public string ChannelId => Set(ref _channelId);
        public string Title => Set(ref _title);
        public bool Assignable => Set(ref _assignable);

        public YoutubeVideoCategory(IApiRequest<VideoCategory, VideoCategoryApiRequestSettings> request) : base(request) { }

        public YoutubeVideoCategory(VideoCategory response) : base(response) { }

        protected override void SetProperties(VideoCategory response)
        {
            if (response == null) return;

            _item = response;
            _id = response.Id;
            _kind = response.Kind;         
            _channelId = response.Snippet?.ChannelId;
            _title = response.Snippet?.Title;
            _assignable = (response.Snippet?.Assignable).GetValueOrDefault();
        }
    }
}