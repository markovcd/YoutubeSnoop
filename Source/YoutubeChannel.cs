using System;
using YoutubeSnoop.Entities.Channels;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubeChannel : YoutubeRequest<ChannelApiRequestSettings, Channel>, IYoutubeItem
    {
        private const string _youtubeUrl = @"https://www.youtube.com/channel/{0}";

        public string Url { get; }
        public string Id { get; }
        public string Title { get; }
        public string Description { get; }
        public string CustomUrl { get; }
        public DateTime PublishedAt { get; }
        public string Country { get; }

        public YoutubeChannel(string id) 
            : this(new ChannelApiRequestSettings { Id = id }) { }

        public YoutubeChannel(ChannelApiRequestSettings settings) : base(settings)
        {
            Id = Response.Id;
            Url = string.Format(_youtubeUrl, Id);
            Title = Response.Snippet.Title;
            Description = Response.Snippet.Description;
            CustomUrl = Response.Snippet.CustomUrl;
            PublishedAt = Response.Snippet.PublishedAt;
            Country = Response.Snippet.Country;
        }  
    }
}