using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.I18nLanguages
{
    public class Snippet
    {
        /// <summary>
        /// A BCP-47 code that uniquely identifies a language.
        /// </summary>
        public string Hl { get; set; }

        /// <summary>
        /// The name of the language as it is written in the language specified using the i18nLanguage.list method's hl parameter.
        /// </summary>
        public string Name { get; set; }
    }
}