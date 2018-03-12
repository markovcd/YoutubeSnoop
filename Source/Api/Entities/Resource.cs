using Newtonsoft.Json;
using System;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities
{
    public class Resource : IResource
    {
        /// <summary>
        /// Identifies the API resource's type.
        /// </summary>
        public ResourceKind Kind { get; set; }

        public static Resource Create(ResourceKind kind, string id)
        {
            switch (kind)
            {
                case ResourceKind.Video: return new ResourceVideo { Kind = kind, VideoId = id };
                case ResourceKind.Playlist: return new ResourcePlaylist { Kind = kind, PlaylistId = id };
                case ResourceKind.Channel: return new ResourceChannel { Kind = kind, ChannelId = id };
                default: throw new InvalidOperationException();
            }
        }
    }
}
