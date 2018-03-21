using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.GuideCategories;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeGuideCategory : YoutubeItem<GuideCategory, GuideCategoryApiRequestSettings>, IYoutubeItem
    {
        private GuideCategory _item;
        private string _id;
        private ResourceKind _kind;
        private string _title;
        private string _channelId;

        public GuideCategory Item => Set(ref _item);
        public string Id => Set(ref _id);
        public ResourceKind Kind => Set(ref _kind);
        public string Title => Set(ref _title);
        public string ChannelId => Set(ref _channelId);

        public YoutubeGuideCategory(IApiRequest<GuideCategory, GuideCategoryApiRequestSettings> request) : base(request) { }

        public YoutubeGuideCategory(GuideCategory response) : base(response) { }

        protected override void SetProperties(GuideCategory response)
        {
            if (response == null) return;

            _item = response;
            _id = response.Id;
            _kind = response.Kind;
            _title = response.Snippet?.Title;
            _channelId = response.Snippet?.ChannelId;           
        }
    }
}