using System;
using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Api.Entities.ChannelSections;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public class YoutubeChannelSection : YoutubeItem<ChannelSection, ChannelSectionApiRequestSettings>, IYoutubeItem
    {
        private ChannelSection _item;
        private string _id;
        private ResourceKind _kind;
        private string _title;
        
        public ChannelSection Item => S(ref _item);
        public string Id => S(ref _id);
        public ResourceKind Kind => S(ref _kind);
        public string Title => S(ref _title);
        
        public YoutubeChannelSection(IApiRequest<ChannelSection, ChannelSectionApiRequestSettings> request) : base(request) { }

        public YoutubeChannelSection(ChannelSection response) : base(response) { }

        protected override void SetProperties(ChannelSection response)
        {
            if (response == null) return;

            _item = response;
            _id = response.Id;
            _kind = response.Kind;
            _title = response.Snippet?.Title;

            //todo
        }
    }
}