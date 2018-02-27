using System;
using YoutubeSnoop.Attributes;
using YoutubeSnoop.Converters;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Settings
{
    public sealed class SearchApiRequestSettings : ApiRequestSettings
    {
        public override RequestType RequestType => RequestType.Search;

        [ApiRequestArgumentName("q")]
        public string Query { get; set; }
        public string ChannelId { get; set; }
        public string ChannelType { get; set; }
        public string EventType { get; set; }
        public string Location { get; set; }
        public string LocationRadius { get; set; }
        public SearchOrder? Order { get; set; }

        [ApiRequestConverter(typeof(DateTimeConverter))]
        public DateTime? PublishedAfter { get; set; }

        [ApiRequestConverter(typeof(DateTimeConverter))]
        public DateTime? PublishedBefore { get; set; }
        public CountryCode? RegionCode { get; set; }
        public string RelatedToVideoId { get; set; }
        public LanguageCode? RelevanceLanguage { get; set; }
        public SafeSearch? SafeSearch { get; set; }
        public string TopicId { get; set; }
        public string VideoCategoryId { get; set; }
        public Duration? VideoDuration { get; set; }
        public string Type { get; set; }
        public Caption? VideoCaption { get; set; }
        public Definition? VideoDefinition { get; set; }

        [ApiRequestConverter(typeof(EnumDescriptionConverter))]
        public Dimension? VideoDimension { get; set; }
        public AnyOrTrue? VideoEmbeddable { get; set; }
        public License? VideoLicense { get; set; }
        public AnyOrTrue? VideoSyndicated { get; set; }
        public VideoType? VideoType { get; set; }
    }
}