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

        public string Id { get; }
        public int? CategoryId { get; }
        public DateTime PublishedAt { get; }
        public string ChannelId { get; }
        public string ChannelTitle { get; }
        public string Title { get; }
        public string Description { get; }

        public YoutubeVideo(IApiRequest<Video> request) : this(request.FirstItem)
        {
            Request = request;
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
            if (int.TryParse(Item.Snippet.CategoryId, out int categoryId)) CategoryId = categoryId;
        }
    }
}