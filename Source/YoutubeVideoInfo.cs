using System;
using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.ApiRequests;

namespace YoutubeSnoop
{
    public class YoutubeVideo
    {
        private const string _youtubeUrl = @"https://www.youtube.com/watch?v={0}";

        public string Url => string.Format(_youtubeUrl, VideoId);
        public string VideoId { get; }
        public DateTime PublishedAt { get; }
        public string ChannelId { get; }
        public string Title { get; }
        public string Description { get; }
        public string ChannelTitle { get; }
        public IDictionary<string, string> Thumbnails { get; }

        internal YoutubeVideo(Entities.Snippet snippet)
        {
            VideoId = snippet.ResourceId?.VideoId;
            PublishedAt = snippet.PublishedAt;
            ChannelId = snippet.ChannelId;
            Title = snippet.Title;
            Description = snippet.Description;
            ChannelTitle = snippet.ChannelTitle;
            Thumbnails = snippet.Thumbnails?.ToDictionary(kv => kv.Key, kv => kv.Value.Url);
        }

        public YoutubeVideo(string id) : this(new VideoApiRequest(id).Response.Items.First().Snippet)
        {
            VideoId = id;
        }
    }

    
}
