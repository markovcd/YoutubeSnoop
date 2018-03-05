using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using YoutubeSnoop.Entities;
using YoutubeSnoop.Entities.Channels;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubeChannel : YoutubeItem<Channel, ChannelApiRequestSettings>, IYoutubeItem
    {
        private Channel _item;
        private string _id;
        private ResourceKind _kind;
        private string _title;
        private string _description;
        private string _customUrl;
        private DateTime _publishedAt;
        private IReadOnlyDictionary<string, Thumbnail> _thumbnails;

        public Channel Item => S(_item);
        public string Id => S(_id);
        public ResourceKind Kind => S(_kind);
        public string Title => S(_title);
        public string Description => S(_description);
        public string CustomUrl => S(_customUrl);
        public DateTime PublishedAt => S(_publishedAt);
        public IReadOnlyDictionary<string, Thumbnail> Thumbnails => S(_thumbnails);

        public YoutubeChannel(IApiRequest<Channel, ChannelApiRequestSettings> request) : base(request) { }

        protected YoutubeChannel() { }

        protected override void SetProperties(Channel response)
        {
            if (response == null) return;

            _item = response;
            _id = response.Id;
            _kind = response.Kind;
            _title = response.Snippet.Title;
            _description = response.Snippet.Description;
            _customUrl = response.Snippet.CustomUrl;
            _publishedAt = response.Snippet.PublishedAt;
            _thumbnails = response.Snippet.Thumbnails?.Clone();

            PropertiesSet = true;
        }

        public static YoutubeChannel FromResponse(Channel response)
        {
            var ch = new YoutubeChannel();
            ch.SetProperties(response);
            return ch;
        }
    }
}