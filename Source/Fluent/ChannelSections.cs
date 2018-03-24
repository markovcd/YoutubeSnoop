using System.Linq;
using YoutubeSnoop.Api;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeChannelSections ChannelSections(ChannelSectionSettings settings, params PartType[] partTypes)
        {
            return new YoutubeChannelSections(settings, partTypes, ResultsPerPage);
        }

        public static YoutubeChannelSection ChannelSection(ChannelSectionSettings settings, params PartType[] partTypes)
        {
            return new YoutubeChannelSection(settings, partTypes);
        }

        public static YoutubeChannelSections ChannelSections(ChannelSectionSettings settings = null)
        {
            return ChannelSections(settings, PartType.Snippet);
        }

        public static YoutubeChannelSection ChannelSection(ChannelSectionSettings settings = null)
        {
            return ChannelSection(settings, PartType.Snippet);
        }

        public static YoutubeChannelSections ChannelSections(params string[] ids)
        {
            return ChannelSections(new ChannelSectionSettings { Id = ids.Aggregate() });
        }

        public static YoutubeChannelSection ChannelSection(string id)
        {
            return ChannelSection(new ChannelSectionSettings { Id = id });
        }

        public static YoutubeChannelSection RequestPart(this YoutubeChannelSection channelSection, PartType partType)
        {
            return ChannelSection(channelSection.Settings.Clone(), channelSection.PartTypes.Append(partType).ToArray());
        }

        public static YoutubeChannelSection RequestContentDetails(this YoutubeChannelSection channelSection)
        {
            return channelSection.RequestPart(PartType.ContentDetails);
        }

        public static YoutubeChannelSection RequestLocalizations(this YoutubeChannelSection channelSection)
        {
            return channelSection.RequestPart(PartType.Localizations);
        }

        public static YoutubeChannelSection RequestTargeting(this YoutubeChannelSection channelSection)
        {
            return channelSection.RequestPart(PartType.Targeting);
        }

        public static YoutubeChannelSection RequestSnippet(this YoutubeChannelSection channelSection)
        {
            return channelSection.RequestPart(PartType.Snippet);
        }

        public static YoutubeChannelSection RequestAllParts(this YoutubeChannelSection channelSection)
        {
            return channelSection.RequestContentDetails()
                                 .RequestLocalizations()
                                 .RequestTargeting()
                                 .RequestSnippet();
        }

        public static YoutubeChannelSections RequestPart(this YoutubeChannelSections channelSections, PartType partType)
        {
            return ChannelSections(channelSections.Settings.Clone(), channelSections.PartTypes.Append(partType).ToArray());
        }

        public static YoutubeChannelSections RequestContentDetails(this YoutubeChannelSections channelSections)
        {
            return channelSections.RequestPart(PartType.ContentDetails);
        }

        public static YoutubeChannelSections RequestLocalizations(this YoutubeChannelSections channelSections)
        {
            return channelSections.RequestPart(PartType.Localizations);
        }

        public static YoutubeChannelSections RequestTargeting(this YoutubeChannelSections channelSections)
        {
            return channelSections.RequestPart(PartType.Targeting);
        }

        public static YoutubeChannelSections RequestSnippet(this YoutubeChannelSections channelSections)
        {
            return channelSections.RequestPart(PartType.Snippet);
        }

        public static YoutubeChannelSections RequestAllParts(this YoutubeChannelSections channelSections)
        {
            return channelSections.RequestContentDetails()
                                 .RequestLocalizations()
                                 .RequestTargeting()
                                 .RequestSnippet();
        }

        public static YoutubeChannelSections RequestId(this YoutubeChannelSections channelSections, params string[] ids)
        {
            var settings = channelSections.Settings.Clone();
            settings.Id = settings.Id.AddItems(ids);
            return ChannelSections(settings, channelSections.PartTypes.ToArray());
        }

        public static YoutubeChannelSections ForChannelId(this YoutubeChannelSections channelSections, string id)
        {
            var settings = channelSections.Settings.Clone();
            settings.ChannelId = id;
            return ChannelSections(settings, channelSections.PartTypes.ToArray());
        }

        public static YoutubeChannels Channels(this YoutubeChannelSection channelSection)
        {
            if (channelSection.ChannelIds == null) channelSection = channelSection.RequestContentDetails();
            if (channelSection.ChannelIds == null) return null;
            return Channels(channelSection.ChannelIds.ToArray());
        }

        public static YoutubePlaylists Playlists(this YoutubeChannelSection channelSection)
        {
            if (channelSection.PlaylistIds == null) channelSection = channelSection.RequestContentDetails();
            if (channelSection.PlaylistIds == null) return null;
            return Playlists(channelSection.PlaylistIds.ToArray());
        }
    }
}