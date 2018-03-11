using System.Linq;
using YoutubeSnoop.Api.Entities.ChannelSections;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeChannelSections ChannelSections(ChannelSectionApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<ChannelSection, ChannelSectionApiRequestSettings>(settings, partTypes);
            return new YoutubeChannelSections(request);
        }

        public static YoutubeChannelSection ChannelSection(ChannelSectionApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<ChannelSection, ChannelSectionApiRequestSettings>(settings, partTypes);
            return new YoutubeChannelSection(request);
        }

        public static YoutubeChannelSections ChannelSections(ChannelSectionApiRequestSettings settings = null)
        {
            return ChannelSections(settings ?? new ChannelSectionApiRequestSettings(), PartType.Snippet);
        }

        public static YoutubeChannelSection ChannelSection(ChannelSectionApiRequestSettings settings = null)
        {
            return ChannelSection(settings ?? new ChannelSectionApiRequestSettings(), PartType.Snippet);
        }

        public static YoutubeChannelSections ChannelSections(params string[] ids)
        {
            return ChannelSections(new ChannelSectionApiRequestSettings { Id = ids.Aggregate((s1, s2) => $"{s1},{s2}") });
        }

        public static YoutubeChannelSection ChannelSection(string id)
        {
            return ChannelSection(new ChannelSectionApiRequestSettings { Id = id });
        }

        public static YoutubeChannelSection RequestPart(this YoutubeChannelSection channelSection, PartType partType)
        {
            var request = channelSection.Request.RequestPart(partType);
            return new YoutubeChannelSection(request);
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
            var request = channelSections.Request.RequestPart(partType);
            return new YoutubeChannelSections(request);
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
            var request = channelSections.Request.Clone();
            if (request.Settings.Id == null) request.Settings.Id = "";

            request.Settings.Id = request.Settings.Id.AddItems(ids);

            return new YoutubeChannelSections(request);
        }

        public static YoutubeChannelSections ForChannelId(this YoutubeChannelSections channelSections, string id)
        {
            var request = channelSections.Request.Clone();
            request.Settings.ChannelId = id;
            return new YoutubeChannelSections(request);
        }
    }
}
