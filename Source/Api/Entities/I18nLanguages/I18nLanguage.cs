namespace YoutubeSnoop.Api.Entities.I18nLanguages
{
    public class I18nLanguage : Response
    {
        /// <summary>
        /// The ID that YouTube uses to uniquely identify the i18n language.
        /// </summary>    
        public string Id { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the i18n language, such as its language code and name.
        /// </summary>
        public Snippet Snippet { get; set; }
    }
}
