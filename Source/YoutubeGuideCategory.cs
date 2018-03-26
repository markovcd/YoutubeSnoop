using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.GuideCategories;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeGuideCategory : YoutubeItem<GuideCategory, GuideCategorySettings>, IYoutubeItem
    {
        private GuideCategory _rawData;
        public GuideCategory RawData => Set(ref _rawData);

        private string _id;
        public string Id => Set(ref _id);

        private ResourceKind _kind;
        public ResourceKind Kind => Set(ref _kind);

        private string _title;
        public string Title => Set(ref _title);

        private string _channelId;
        public string ChannelId => Set(ref _channelId);

        public YoutubeGuideCategory(GuideCategory response) : base(response)
        {
        }

        public YoutubeGuideCategory(GuideCategorySettings settings, IEnumerable<PartType> partTypes = null) : base(settings, partTypes)
        {
        }

        protected override void SetProperties(GuideCategory response)
        {
            if (response == null) return;

            _rawData = response;
            _id = response.Id;
            _kind = response.Kind;

            if (response.Snippet == null) return;

            _title = response.Snippet.Title;
            _channelId = response.Snippet.ChannelId;
        }
    }
}