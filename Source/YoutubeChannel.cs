using System;
using System.Linq;
using YoutubeSnoop.Entities.Channels;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubeChannel : IYoutubeItem
    {
        public IApiRequest<Channel> Request { get; }
        public Channel Item { get; }

        public string Id { get; }
        public string Title { get; }
        public string Description { get; }
        public string CustomUrl { get; }
        public DateTime PublishedAt { get; }
      
        public YoutubeChannel(IApiRequest<Channel> request) : this(request.FirstItem)
        {
            Request = request;
        }

        public YoutubeChannel(Channel channel)
        {
            Item = channel;
            if (Item == null) return;

            Id = Item.Id;
            Title = Item.Snippet.Title;
            Description = Item.Snippet.Description;
            CustomUrl = Item.Snippet.CustomUrl;
            PublishedAt = Item.Snippet.PublishedAt;
        }
    }
}