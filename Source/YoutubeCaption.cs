using System;
using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Api.Entities.Captions;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public class YoutubeCaption : YoutubeItem<Caption, CaptionApiRequestSettings>, IYoutubeItem
    {
        private Caption _item;
        private string _id;
        private ResourceKind _kind;
        
        public Caption Item => S(ref _item);
        public string Id => S(ref _id);
        public ResourceKind Kind => S(ref _kind);
       
        public YoutubeCaption(IApiRequest<Caption, CaptionApiRequestSettings> request) : base(request) { }

        public YoutubeCaption(Caption response) : base(response) { }

        protected override void SetProperties(Caption response)
        {
            if (response == null) return;

            _item = response;
            _id = response.Id;
            _kind = response.Kind;
            // todo
        }
    }
}