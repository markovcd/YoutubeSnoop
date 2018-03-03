using System;
using System.ComponentModel;
using System.Reflection;
using YoutubeSnoop.Entities;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
{
    public static class Extensions
    {
        public static string GetDescription(this Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
            if (fieldInfo == null) return null;
            var attribute = fieldInfo.GetCustomAttribute<DescriptionAttribute>();
            return attribute?.Description;
        }

        public static string ToCamelCase(this string value)
        {
            return value.Substring(0, 1).ToLower() + value.Substring(1);
        }

        public static string ToCamelCase(this Enum value)
        {
            return ToCamelCase(value.ToString());
        }

        public static string GetId(this IResource resourceId)
        {
            switch (resourceId.Kind)
            {
                case ResourceKind.Video: return ((ResourceIdVideo)resourceId).VideoId;
                case ResourceKind.Playlist: return ((ResourceIdPlaylist)resourceId).PlaylistId;
                case ResourceKind.Channel: return ((ResourceIdChannel)resourceId).ChannelId;
                default: throw new InvalidOperationException();
            }
        }

        public static IYoutubeItem GetYoutubeItem(this IResource resourceId)
        {
            var id = resourceId.GetId();

            switch (resourceId.Kind)
            {
                case ResourceKind.Video: return new YoutubeVideo(id);
                case ResourceKind.Playlist: return new YoutubePlaylist(id);
                case ResourceKind.Channel: return new YoutubeChannel(id);
                default: throw new InvalidOperationException();
            }
        }

        public static string GetUrl(ResourceKind kind, string id)
        {
            const string _playlistUrl = @"https://www.youtube.com/playlist?list={0}";
            const string _channelUrl = @"https://www.youtube.com/channel/{0}";
            const string _videoUrl = @"https://www.youtube.com/watch?v={0}";

            switch (kind)
            {
                case ResourceKind.Video: return string.Format(_videoUrl, id);
                case ResourceKind.Playlist: return string.Format(_playlistUrl, id);
                case ResourceKind.Channel: return string.Format(_channelUrl, id);
                default: throw new InvalidOperationException();
            }
        }
    }
}