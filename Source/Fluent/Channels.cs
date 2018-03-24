using System.Linq;
using YoutubeSnoop.Api;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeChannels Channels(ChannelSettings settings, params PartType[] partTypes)
        {
            return new YoutubeChannels(settings, partTypes, ResultsPerPage);
        }

        public static YoutubeChannel Channel(ChannelSettings settings, params PartType[] partTypes)
        {
            return new YoutubeChannel(settings, partTypes);
        }

        public static YoutubeChannels Channels(ChannelSettings settings = null)
        {
            return Channels(settings, PartType.Snippet, PartType.ContentDetails);
        }

        public static YoutubeChannel Channel(ChannelSettings settings = null)
        {
            return Channel(settings, PartType.Snippet, PartType.ContentDetails);
        }

        public static YoutubeChannels Channels(params string[] ids)
        {
            return Channels(new ChannelSettings { Id = ids.Aggregate() });
        }

        public static YoutubeChannel Channel(string id)
        {
            return Channel(new ChannelSettings { Id = id });
        }

        public static YoutubeChannel ForUsername(this YoutubeChannel channel, string username)
        {
            var settings = channel.Settings.Clone();
            settings.ForUsername = username;
            return Channel(settings, channel.PartTypes.ToArray());
        }

        public static YoutubeChannels ForUsername(this YoutubeChannels channels, string username)
        {
            var settings = channels.Settings.Clone();
            settings.ForUsername = username;
            return Channels(settings, channels.PartTypes.ToArray());
        }

        public static YoutubeChannels RequestId(this YoutubeChannels channels, params string[] ids)
        {
            var settings = channels.Settings.Clone();
            settings.Id = settings.Id.AddItems(ids);
            return Channels(settings, channels.PartTypes.ToArray());
        }

        public static YoutubeChannel RequestPart(this YoutubeChannel channel, PartType partType)
        {
            return Channel(channel.Settings.Clone(), channel.PartTypes.Append(partType).ToArray());
        }

        public static YoutubeChannel RequestContentDetails(this YoutubeChannel channel)
        {
            return channel.RequestPart(PartType.ContentDetails);
        }

        public static YoutubeChannel RequestContentOwnerDetails(this YoutubeChannel channel)
        {
            return channel.RequestPart(PartType.ContentOwnerDetails);
        }

        public static YoutubeChannel RequestStatistics(this YoutubeChannel channel)
        {
            return channel.RequestPart(PartType.Statistics);
        }

        public static YoutubeChannel RequestBrandingSettings(this YoutubeChannel channel)
        {
            return channel.RequestPart(PartType.BrandingSettings);
        }

        public static YoutubeChannel RequestStatus(this YoutubeChannel channel)
        {
            return channel.RequestPart(PartType.Status);
        }

        public static YoutubeChannel RequestLocalizations(this YoutubeChannel channel)
        {
            return channel.RequestPart(PartType.Localizations);
        }

        public static YoutubeChannel RequestTopicDetails(this YoutubeChannel channel)
        {
            return channel.RequestPart(PartType.TopicDetails);
        }

        public static YoutubeChannel RequestSnippet(this YoutubeChannel channel)
        {
            return channel.RequestPart(PartType.Snippet);
        }

        public static YoutubeChannel RequestAllParts(this YoutubeChannel channel)
        {
            return channel.RequestContentDetails()
                           .RequestBrandingSettings()
                           .RequestContentOwnerDetails()
                           .RequestLocalizations()
                           .RequestStatistics()
                           .RequestStatus()
                           .RequestTopicDetails()
                           .RequestSnippet();
        }

        public static YoutubeChannels RequestPart(this YoutubeChannels channels, PartType partType)
        {
            return Channels(channels.Settings.Clone(), channels.PartTypes.Append(partType).ToArray());
        }

        public static YoutubeChannels RequestContentDetails(this YoutubeChannels channels)
        {
            return channels.RequestPart(PartType.ContentDetails);
        }

        public static YoutubeChannels RequestContentOwnerDetails(this YoutubeChannels channels)
        {
            return channels.RequestPart(PartType.ContentOwnerDetails);
        }

        public static YoutubeChannels RequestStatistics(this YoutubeChannels channels)
        {
            return channels.RequestPart(PartType.Statistics);
        }

        public static YoutubeChannels RequestBrandingSettings(this YoutubeChannels channels)
        {
            return channels.RequestPart(PartType.BrandingSettings);
        }

        public static YoutubeChannels RequestStatus(this YoutubeChannels channels)
        {
            return channels.RequestPart(PartType.Status);
        }

        public static YoutubeChannels RequestLocalizations(this YoutubeChannels channels)
        {
            return channels.RequestPart(PartType.Localizations);
        }

        public static YoutubeChannels RequestTopicDetails(this YoutubeChannels channels)
        {
            return channels.RequestPart(PartType.TopicDetails);
        }

        public static YoutubeChannels RequestSnippet(this YoutubeChannels channels)
        {
            return channels.RequestPart(PartType.Snippet);
        }

        public static YoutubeChannels RequestAllParts(this YoutubeChannels channels)
        {
            return channels.RequestContentDetails()
                           .RequestBrandingSettings()
                           .RequestContentOwnerDetails()
                           .RequestLocalizations()
                           .RequestStatistics()
                           .RequestStatus()
                           .RequestTopicDetails()
                           .RequestSnippet();
        }

        public static YoutubePlaylistItems Uploads(this YoutubeChannel channel)
        {
            if (channel.UploadsPlaylistId == null) channel = channel.RequestContentDetails();
            return PlaylistItems(channel.UploadsPlaylistId);
        }

        public static YoutubePlaylists Playlists(this YoutubeChannel channel)
        {
            return Playlists().ForChannelId(channel.Id);
        }

        public static YoutubeActivities Activities(this YoutubeChannel channel)
        {
            return Activities().ForChannelId(channel.Id);
        }

        public static YoutubeChannelSections Sections(this YoutubeChannel channel)
        {
            return ChannelSections().ForChannelId(channel.Id);
        }

        public static YoutubeSearch Search(this YoutubeChannel channel)
        {
            return Search().ForChannelId(channel.Id);
        }

        public static YoutubeSearch Search(this YoutubeChannel channel, string query)
        {
            return Search(query).ForChannelId(channel.Id);
        }

        public static YoutubeCommentThreads Comments(this YoutubeChannel channel)
        {
            return CommentThreads().ForChannelId(channel.Id);
        }

        public static YoutubeCommentThreads AllComments(this YoutubeChannel channel)
        {
            return CommentThreads().ForChannelIdAll(channel.Id);
        }

        public static YoutubeSubscriptions Subscriptions(this YoutubeChannel channel)
        {
            return Subscriptions().ForChannelId(channel.Id);
        }
    }
}