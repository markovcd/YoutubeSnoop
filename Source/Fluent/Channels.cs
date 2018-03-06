using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YoutubeSnoop.Entities.Channels;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeChannels Channels(ChannelApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<Channel, ChannelApiRequestSettings>(settings, partTypes);
            return new YoutubeChannels(request);
        }

        public static YoutubeChannel Channel(ChannelApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<Channel, ChannelApiRequestSettings>(settings, partTypes);
            return new YoutubeChannel(request);
        }

        public static YoutubeChannels Channels(ChannelApiRequestSettings settings = null)
        {
            return Channels(settings ?? new ChannelApiRequestSettings(), PartType.Snippet);
        }

        public static YoutubeChannel Channel(ChannelApiRequestSettings settings = null)
        {
            return Channel(settings ?? new ChannelApiRequestSettings(), PartType.Snippet, PartType.ContentDetails);
        }

        public static YoutubeChannels Channels(params string[] ids)
        {
            return Channels(new ChannelApiRequestSettings { Id = ids.Aggregate((s1, s2) => $"{s1},{s2}") });
        }

        public static YoutubeChannel Channel(string id)
        {
            return Channel(new ChannelApiRequestSettings { Id = id });
        }

        public static YoutubeChannel ForUsername(this YoutubeChannel channel, string username)
        {
            var request = channel.Request.Clone();
            return Channel(new ChannelApiRequestSettings { ForUsername = username });
        }

        public static YoutubeChannel RequestPart(this YoutubeChannel channel, PartType partType)
        {
            var request = channel.Request.Clone(channel.Request.PartTypes.Concat(new[] { partType }).Distinct());
            return new YoutubeChannel(request);
        }

        public static YoutubePlaylistItems Uploads(this YoutubeChannel channel)
        {
            if (channel.Item.ContentDetails == null) channel = channel.RequestPart(PartType.ContentDetails);
            var id = channel.Item.ContentDetails.RelatedPlaylists.Uploads;
            return PlaylistItems().PlaylistId(id);
        }

        public static YoutubePlaylists Playlists(this YoutubeChannel channel)
        {
            return Playlists().ChannelId(channel.Id);
        }
    }
}
