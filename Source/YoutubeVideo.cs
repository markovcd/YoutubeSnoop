using System;
using YoutubeSnoop.Entities.Videos;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubeVideo : IYoutubeItem
    {
        public ApiRequestSingle<Video, VideoApiRequestSettings> Request { get; }

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

        public YoutubeVideo(VideoApiRequestSettings settings)
        {
            Request = new ApiRequestSingle<Video, VideoApiRequestSettings>(settings);
            if (Request.Item == null) return;

            Id = Request.Item.Id;
            PublishedAt = Request.Item.Snippet.PublishedAt;
            ChannelId = Request.Item.Snippet.ChannelId;
            ChannelTitle = Request.Item.Snippet.ChannelTitle;
            Description = Request.Item.Snippet.Description;
            Title = Request.Item.Snippet.Title;

            Url = Extensions.GetUrl(Request.Item.Kind, Request.Item.Id);
            if (int.TryParse(Request.Item.Snippet.CategoryId, out int categoryId)) CategoryId = categoryId;
        }

        public YoutubeVideo(Video video)
        {           
            Id = video.Id;
            PublishedAt = video.Snippet.PublishedAt;
            ChannelId = video.Snippet.ChannelId;
            ChannelTitle = video.Snippet.ChannelTitle;
            Description = video.Snippet.Description;
            Title = video.Snippet.Title;

            Url = Extensions.GetUrl(video.Kind, video.Id);
            if (int.TryParse(video.Snippet.CategoryId, out int categoryId)) CategoryId = categoryId;
        }
    }
}