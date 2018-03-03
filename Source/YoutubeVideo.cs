using System;
using YoutubeSnoop.Entities.Videos;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubeVideo : YoutubeRequest<VideoApiRequestSettings, Video>, IYoutubeItem
    {
        public string Url { get; }
        public string Id { get; }
        public int? CategoryId { get; }
        public DateTime PublishedAt { get; }
        public string ChannelId { get; }
        public string ChannelTitle { get; }
        public string Title { get; }
        public string Description { get; }

        public YoutubeVideo(string id)
            : this(new VideoApiRequestSettings { Id = id }) { }

        public YoutubeVideo(VideoApiRequestSettings settings) : base(settings)
        {
            Id = Response.Id;
            Url = Extensions.GetUrl(Response.Kind, Response.Id);
            PublishedAt = Response.Snippet.PublishedAt;
            ChannelId = Response.Snippet.ChannelId;
            ChannelTitle = Response.Snippet.ChannelTitle;
            Description = Response.Snippet.Description;
            Title = Response.Snippet.Title;

            if (int.TryParse(Response.Snippet.CategoryId, out int categoryId)) CategoryId = categoryId;
        }
    }
}