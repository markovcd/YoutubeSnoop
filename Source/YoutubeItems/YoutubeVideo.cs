using System;
using System.Linq;
using YoutubeSnoop.Entities.Videos;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using YoutubeSnoop.Entities;

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
        public IReadOnlyDictionary<string, Thumbnail> Thumbnails { get; }

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

            var d = Item.Snippet.Thumbnails.ToDictionary(kv => kv.Key, kv => kv.Value);
            Thumbnails = new ReadOnlyDictionary<string, Thumbnail>(d);
        }
    }
}