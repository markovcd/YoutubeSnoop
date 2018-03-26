using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api
{
    public sealed class VideoCategorySettings : Settings
    {
        public override RequestType RequestType => RequestType.VideoCategories;

        /// <summary>
        /// Specifies a comma-separated list of video category IDs for the resources that you are retrieving.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Instructs the API to return the list of video categories available in the specified country. The parameter value is an ISO 3166-1 alpha-2 country code.
        /// </summary>
        public string RegionCode { get; set; }

        /// <summary>
        /// Specifies the language that should be used for text values in the API response. The default value is en_US.
        /// </summary>
        public string Hl { get; set; }
    }
}