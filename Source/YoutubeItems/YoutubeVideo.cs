using System;
using System.Linq;
using YoutubeSnoop.Entities.Videos;
using YoutubeSnoop.Interfaces;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using YoutubeSnoop.Entities;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubeVideo : IYoutubeItem
    {
        public IApiRequest<Video, VideoApiRequestSettings> Request { get; }
        public Video Item { get; }
        public string Id { get; }
        public ResourceKind Kind { get; }
        public int? CategoryId { get; }
        public DateTime PublishedAt { get; }
        public string ChannelId { get; }
        public string ChannelTitle { get; }
        public string Title { get; }
        public string Description { get; }
        public IReadOnlyDictionary<string, Thumbnail> Thumbnails { get; }

        public YoutubeVideo(IApiRequest<Video, VideoApiRequestSettings> request) : this(request.FirstItem)
        {
            Request = request;
        }

        public YoutubeVideo(Video video)
        {
            Item = video;
            if (Item == null) return;

            Id = Item.Id;
            Kind = Item.Kind;
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