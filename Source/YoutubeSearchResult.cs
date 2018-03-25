using System;
using System.Collections.Generic;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Api.Entities.Search;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeSearchResult : IYoutubeItem
    {
        public SearchResult RawData { get; }
        public ResourceKind Kind { get; }
        public ResourceKind ResultKind { get; }
        public string Id { get; }
        public DateTime PublishedAt { get; }
        public string ChannelId { get; }
        public string Title { get; }
        public string Description { get; }
        public string ChannelTitle { get; }
        public IReadOnlyDictionary<ThumbnailSize, Thumbnail> Thumbnails { get; }
        public string Url { get; }

        public YoutubeSearchResult(SearchResult response)
        {
            if (response == null) return;

            RawData = response;
            Kind = response.Kind;
            ResultKind = response.Id.Kind;
            Id = response.Id.Id();

            switch (ResultKind)
            {
                case ResourceKind.Channel: Url = YoutubeChannel.GetUrl(Id); break;
                case ResourceKind.Playlist: Url = YoutubePlaylist.GetUrl(Id); break;
                case ResourceKind.Video: Url = YoutubeVideo.GetUrl(Id); break;

                default: throw new InvalidOperationException();
            }

            if (response.Snippet == null) return;

            PublishedAt = response.Snippet.PublishedAt.GetValueOrDefault();
            ChannelId = response.Snippet.ChannelId;
            Title = response.Snippet.Title;
            Description = response.Snippet.Description;
            ChannelTitle = response.Snippet.ChannelTitle;
            Thumbnails = response.Snippet.Thumbnails?.Clone();
            
        }
    }
}