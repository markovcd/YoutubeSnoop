using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using YoutubeSnoop.Api.Attributes;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public static class Extensions
    {
        private const string _playlistUrl = @"https://www.youtube.com/playlist?list={0}";
        private const string _channelUrl = @"https://www.youtube.com/channel/{0}";
        private const string _videoUrl = @"https://www.youtube.com/watch?v={0}";

        public static string GetDescription(this Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
            if (fieldInfo == null) return null;
            var attribute = fieldInfo.GetCustomAttribute<DescriptionAttribute>();
            return attribute?.Description;
        }

        /// <summary>
        /// Gets an attribute on an enum field value
        /// </summary>
        /// <typeparam name="T">The type of the attribute you want to retrieve</typeparam>
        /// <param name="enumVal">The enum value</param>
        /// <returns>The attribute of type T that exists on the enum value</returns>
        /// <example>string desc = myEnumVariable.GetAttributeOfType<DescriptionAttribute>().Description;</example>
        public static T GetAttributeOfType<T>(this Enum enumVal) where T : Attribute
        {
            var type = enumVal.GetType();
            var memInfo = type.GetMember(enumVal.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(T), false);

            return (attributes.Length > 0) ? (T)attributes[0] : null;
        }

        public static Type GetMappedResponse(this ResourceKind kind)
        {
            if (kind == ResourceKind.None) throw new InvalidOperationException();

            var entityAttr = kind.GetAttributeOfType<EntityMappingAttribute>();
            if (entityAttr != null) return entityAttr.EntityType;

            var apiAttr = kind.GetAttributeOfType<ApiMappingAttribute>();
            if (apiAttr == null) return null;

            return typeof(PagedResponse<>).MakeGenericType(apiAttr.EntityType);
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

        public static string Id(this Resource resourceId)
        {
            switch (resourceId.Kind)
            {
                case ResourceKind.Video: return resourceId.VideoId;
                case ResourceKind.Playlist: return resourceId.PlaylistId;
                case ResourceKind.Channel: return resourceId.ChannelId;
                default: throw new InvalidOperationException();
            }
        }

        public static string Url(this Resource resourceId)
        {
            var id = resourceId?.Id();

            switch (resourceId?.Kind)
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

        public static IReadOnlyDictionary<ThumbnailSize, Thumbnail> Clone(this IDictionary<ThumbnailSize, Thumbnail> thumbnails)
        {
            var t = thumbnails?.ToDictionary(kv => kv.Key, kv => kv.Value);
            if (t == null) return null;
            return new ReadOnlyDictionary<ThumbnailSize, Thumbnail>(t);
        }

        public static IApiRequestSettings Clone(this IApiRequestSettings settings)
        {
            var type = settings?.GetType();

            if (type == null) return null;

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

        public static ResourceKind ParseResourceKind(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return ResourceKind.None;

            s = s.Split('#')[1];

            if (!Enum.TryParse<ResourceKind>(s, true, out var result)) return ResourceKind.None;

            return result;
        }

        public static string AddItems(this string s, params string[] items)
        {
            return s?.Split(',')
                     .Concat(items)
                     .Distinct()
                     .Aggregate((s1, s2) => $"{s1},{s2}");
        }
    }
}