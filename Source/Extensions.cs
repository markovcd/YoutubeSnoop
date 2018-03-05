using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using YoutubeSnoop.Attributes;
using YoutubeSnoop.Entities;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
{
    public static class Extensions
    {
        const string _playlistUrl = @"https://www.youtube.com/playlist?list={0}";
        const string _channelUrl = @"https://www.youtube.com/channel/{0}";
        const string _videoUrl = @"https://www.youtube.com/watch?v={0}";

        public static string GetDescription(this Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
            if (fieldInfo == null) return null;
            var attribute = fieldInfo.GetCustomAttribute<DescriptionAttribute>();
            return attribute?.Description;
        }

        public static string ToCamelCase(this string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            return value.Substring(0, 1).ToLower() + value.Substring(1);
        }

        public static string ToCamelCase(this Enum value)
        {
            return ToCamelCase(value.ToString());
        }

        public static string Id(this IResource resourceId)
        {
            switch (resourceId.Kind)
            {
                case ResourceKind.Video: return ((ResourceIdVideo)resourceId).VideoId;
                case ResourceKind.Playlist: return ((ResourceIdPlaylist)resourceId).PlaylistId;
                case ResourceKind.Channel: return ((ResourceIdChannel)resourceId).ChannelId;
                default: throw new InvalidOperationException();
            }
        }

        public static IYoutubeItem ToYoutubeItem(this IResource resourceId)
        {
            var id = resourceId.Id();

            switch (resourceId.Kind)
            {
                case ResourceKind.Video: return Youtube.Video(id);
                case ResourceKind.Playlist: return Youtube.Playlist(id);
                case ResourceKind.Channel: return Youtube.Channel(id);
                default: throw new InvalidOperationException();
            }
        }

        public static string Url(this IResource resourceId)
        {
            var id = resourceId.Id();

            switch (resourceId.Kind)
            {
                case ResourceKind.Video: return string.Format(_videoUrl, id);
                case ResourceKind.Playlist: return string.Format(_playlistUrl, id);
                case ResourceKind.Channel: return string.Format(_channelUrl, id);
                default: throw new InvalidOperationException();
            }
        }

        public static string Url(this IYoutubeItem youtubeItem)
        {
            if (youtubeItem is YoutubeVideo) return string.Format(_videoUrl, youtubeItem.Id);
            if (youtubeItem is YoutubePlaylist) return string.Format(_playlistUrl, youtubeItem.Id);
            if (youtubeItem is YoutubeChannel) return string.Format(_channelUrl, youtubeItem.Id);
            if (youtubeItem is YoutubeSearchResult) return (youtubeItem as YoutubeSearchResult).Item.Id.Url();
            if (youtubeItem is YoutubePlaylistItem) return (youtubeItem as YoutubePlaylistItem).Item.Snippet.ResourceId.Url();
        
            throw new InvalidOperationException();
        }

        public static IReadOnlyDictionary<string, Thumbnail> Clone(this IDictionary<string, Thumbnail> thumbnails)
        {
            var t = thumbnails?.ToDictionary(kv => kv.Key, kv => kv.Value);
            if (t == null) return null;
            return new ReadOnlyDictionary<string, Thumbnail>(t);
        }

        public static IApiRequestSettings Clone(this IApiRequestSettings settings)
        {
            var type = settings.GetType();

            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                 .Where(p => !p.IsDefined(typeof(ApiRequestIgnoreAttribute)));

            var cloned = Activator.CreateInstance(type);

            foreach (var property in properties)
            {
                var value = property.GetValue(settings);
                property.SetValue(cloned, value);
            }

            return (IApiRequestSettings)cloned;
        }
    }
}