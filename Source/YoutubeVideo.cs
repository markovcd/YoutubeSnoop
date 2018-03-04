using System;
using System.Linq;
using YoutubeSnoop.Entities.Videos;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubeVideo : IYoutubeItem
    {
        public IApiRequest<Video> Request { get; }
        public Video Item { get; }

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
            Item = Request.Items.FirstOrDefault();
            if (Item == null) return;

            Id = Item.Id;
            PublishedAt = Item.Snippet.PublishedAt;
            ChannelId = Item.Snippet.ChannelId;
            ChannelTitle = Item.Snippet.ChannelTitle;
            Description = Item.Snippet.Description;
            Title = Item.Snippet.Title;

            Url = Extensions.GetUrl(Item.Kind, Item.Id);
            if (int.TryParse(Item.Snippet.CategoryId, out int categoryId)) CategoryId = categoryId;
        }

        public YoutubeVideo(Video video)
        {
            Item = video;
            if (Item == null) return;

            Id = Item.Id;
            PublishedAt = Item.Snippet.PublishedAt;
            ChannelId = Item.Snippet.ChannelId;
            ChannelTitle = Item.Snippet.ChannelTitle;
            Description = Item.Snippet.Description;
            Title = Item.Snippet.Title;

            Url = Extensions.GetUrl(Item.Kind, Item.Id);
            if (int.TryParse(Item.Snippet.CategoryId, out int categoryId)) CategoryId = categoryId;
        }
    }
}