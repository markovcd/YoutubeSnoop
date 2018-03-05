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
    public class YoutubeChannel : IYoutubeItem
    {
        private string _id;
        private ResourceKind _kind;
        private string _title;
        private string _description;
        private string _customUrl;
        private DateTime _publishedAt;
        private IReadOnlyDictionary<string, Thumbnail> _thumbnails;

        public IApiRequest<Channel, ChannelApiRequestSettings> Request { get; }
        public Channel Item { get; }

        public string Id
        {
            get
            {
                return _id;
            }
        }

        public ResourceKind Kind => _kind;
        public string Title => _title;
        public string Description => _description;
        public string CustomUrl => _customUrl;
        public DateTime PublishedAt => _publishedAt;
        public IReadOnlyDictionary<string, Thumbnail> Thumbnails => _thumbnails;


        public YoutubeChannel(IApiRequest<Channel, ChannelApiRequestSettings> request) : this(request.FirstItem)
        {
            Request = request;
            Request.FirstItemDownloaded += Request_FirstItemDownloaded;
        }

        private void Request_FirstItemDownloaded(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public YoutubeChannel(Channel channel)
        {
            Item = channel;
            if (Item == null) return;

            Id = Item.Id;
            Kind = Item.Kind;
            Title = Item.Snippet.Title;
            Description = Item.Snippet.Description;
            CustomUrl = Item.Snippet.CustomUrl;
            PublishedAt = Item.Snippet.PublishedAt;

            var d = Item.Snippet.Thumbnails.ToDictionary(kv => kv.Key, kv => kv.Value);
            Thumbnails = new ReadOnlyDictionary<string, Thumbnail>(d);
        }
    }
}