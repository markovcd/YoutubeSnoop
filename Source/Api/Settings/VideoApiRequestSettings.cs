using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Settings
{
    public sealed class VideoApiRequestSettings : ApiRequestSettings
    {
        public override RequestType RequestType => RequestType.Videos;

        /// <summary>
        /// Specifies a comma-separated list of the YouTube video ID(s) for the resource(s) that are being retrieved. In a video resource, the id property specifies the video's ID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Identifies the chart that you want to retrieve.
        /// </summary>
        public Chart? Chart { get; set; }

        /// <summary>
        /// Instructs the API to retrieve localized resource metadata for a specific application language that the YouTube website supports. The parameter value must be a language code included in the list returned by the i18nLanguages.list method.
        /// </summary>
        public string Hl { get; set; }

        /// <summary>
        /// Specifies the maximum height of the embedded player returned in the player.embedHtml property. You can use this parameter to specify that instead of the default dimensions, the embed code should use a height appropriate for your application layout. If the maxWidth parameter is also provided, the player may be shorter than the maxHeight in order to not violate the maximum width. Acceptable values are 72 to 8192, inclusive.
        /// </summary>
        public int? MaxHeight { get; set; }

        /// <summary>
        /// Specifies the maximum width of the embedded player returned in the player.embedHtml property. You can use this parameter to specify that instead of the default dimensions, the embed code should use a width appropriate for your application layout.
        /// </summary>
        /// <remarks>
        /// If the maxHeight parameter is also provided, the player may be narrower than maxWidth in order to not violate the maximum height. Acceptable values are 72 to 8192, inclusive.
        /// </remarks>
        public int? MaxWidth { get; set; }

        /// <summary>
        /// Instructs the API to select a video chart available in the specified region. This parameter can only be used in conjunction with the chart parameter. The parameter value is an ISO 3166-1 alpha-2 country code.
        /// </summary>
        public string RegionCode { get; set; }

        /// <summary>
        /// Identifies the video category for which the chart should be retrieved. This parameter can only be used in conjunction with the chart parameter. By default, charts are not restricted to a particular category. The default value is 0.
        /// </summary>
        public int? VideoCategoryId { get; set; }
    }
}