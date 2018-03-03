using System;
using YoutubeSnoop.Entities.Videos;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubeVideo : YoutubeRequest<VideoApiRequestSettings, Video>, IYoutubeItem
    {
        private const string _youtubeUrl = @"https://www.youtube.com/watch?v={0}";

        public string Url { get; }
        public string Id { get; }
        public int? CategoryId { get; }
        public DateTime PublishedAt { get; }
        public string ChannelId { get; }
        public string ChannelTitle { get; }
        public string Title { get; }
        public string Description { get; }
        public string DefaultLanguage { get; }

        public YoutubeVideo(string id) 
            : this(new VideoApiRequestSettings { Id = id }) { }

        public YoutubeVideo(VideoApiRequestSettings settings) : base(settings)
        {
            Id = Response.Id;
            Url = string.Format(_youtubeUrl, Id);
            PublishedAt = Response.Snippet.PublishedAt;
            ChannelId = Response.Snippet.ChannelId;
            ChannelTitle = Response.Snippet.ChannelTitle;
            Description = Response.Snippet.Description;
            Title = Response.Snippet.Title;
            DefaultLanguage = Response.Snippet.DefaultLanguage;

            if (int.TryParse(Response.Snippet.CategoryId, out int categoryId)) CategoryId = categoryId;
        }
    }
}