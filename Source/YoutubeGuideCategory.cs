using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.GuideCategories;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public class YoutubeGuideCategory : YoutubeItem<GuideCategory, GuideCategoryApiRequestSettings>, IYoutubeItem
    {
        private GuideCategory _item;
        private string _id;
        private ResourceKind _kind;
        private string _title;
        private string _channelId;

        public GuideCategory Item => S(ref _item);
        public string Id => S(ref _id);
        public ResourceKind Kind => S(ref _kind);
        public string Title => S(ref _title);
        public string ChannelId => S(ref _channelId);

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