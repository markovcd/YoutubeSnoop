using System;
using YoutubeSnoop.Entities.Channels;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubeChannel : YoutubeRequest<ChannelApiRequestSettings, Channel>, IYoutubeItem
    {      
        public string Url { get; }
        public string Id { get; }
        public string Title { get; }
        public string Description { get; }
        public string CustomUrl { get; }
        public DateTime PublishedAt { get; }

        public YoutubeChannel(string id)
            : this(new ChannelApiRequestSettings { Id = id }) { }

        public YoutubeChannel(ChannelApiRequestSettings settings) : base(settings)
        {
            Id = Response.Id;
            Url = Extensions.GetUrl(Response.Kind, Response.Id);
            Title = Response.Snippet.Title;
            Description = Response.Snippet.Description;
            CustomUrl = Response.Snippet.CustomUrl;
            PublishedAt = Response.Snippet.PublishedAt;
        }
    }
}