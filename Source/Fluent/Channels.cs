using System.Linq;
using YoutubeSnoop.Api.Entities.Channels;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

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
            return Channels(settings ?? new ChannelApiRequestSettings(), PartType.Snippet, PartType.ContentDetails);
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
            request.Settings.ForUsername = username;
            return new YoutubeChannel(request);
        }

        public static YoutubeChannels ForUsername(this YoutubeChannels channels, string username)
        {
            var request = channels.Request.Clone();
            request.Settings.ForUsername = username;
            return new YoutubeChannels(request);
        }

        public static YoutubeChannels RequestId(this YoutubeChannels channels, params string[] ids)
        {
            var request = channels.Request.Clone();
            if (request.Settings.Id == null) request.Settings.Id = "";

            request.Settings.Id = request.Settings.Id.AddItems(ids);

            return new YoutubeChannels(request);
        }

        public static YoutubeChannel RequestPart(this YoutubeChannel channel, PartType partType)
        {
            var request = channel.Request.RequestPart(partType);
            return new YoutubeChannel(request);
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
            var request = channels.Request.RequestPart(partType);
            return new YoutubeChannels(request);
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
            if (channel.Item.ContentDetails == null) channel = channel.RequestContentDetails();
            var id = channel.Item.ContentDetails.RelatedPlaylists.Uploads;
            return PlaylistItems(id);
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

        public static YoutubeCommentThreads Comments(this YoutubeChannel channel)
        {
            return CommentThreads().ForChannelId(channel.Id);
        }

        public static YoutubeSubscriptions Subscriptions(this YoutubeChannel channel)
        {
            return Subscriptions().ForChannelId(channel.Id);
        }
    }
}
