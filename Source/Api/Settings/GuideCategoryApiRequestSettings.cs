using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Settings
{
    public sealed class GuideCategoryApiRequestSettings : ApiRequestSettings
    {
        public override RequestType RequestType => RequestType.GuideCategories;

        /// <summary>
        /// Specifies a comma-separated list of the YouTube channel category ID(s) for the resource(s) that are being retrieved. In a guideCategory resource, the id property specifies the YouTube channel category ID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Instructs the API to return the list of guide categories available in the specified country. The parameter value is an ISO 3166-1 alpha-2 country code.
        /// </summary>
        public string RegionCode { get; set; }

        /// <summary>
        /// Specifies the language that will be used for text values in the API response. The default value is en-US.
        /// </summary>
        public string Hl { get; set; }
    }
}