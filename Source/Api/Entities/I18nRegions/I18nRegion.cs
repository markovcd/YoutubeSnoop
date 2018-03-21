namespace YoutubeSnoop.Api.Entities.I18nRegions
{
    public class I18nRegion : Response
    {
        /// <summary>
        /// The ID that YouTube uses to uniquely identify the i18n region.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the i18n region, such as its region code and name.
        /// </summary>
        public Snippet Snippet { get; set; }
    }
}