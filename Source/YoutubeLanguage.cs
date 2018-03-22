﻿using YoutubeSnoop.Api.Entities.I18nLanguages;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeLanguage : IYoutubeItem
    {
        public ResourceKind Kind { get; }
        public string Id { get; }
        public string LanguageCode { get; }
        public string LanguageName { get; }

        public YoutubeLanguage(I18nLanguage response)
        {
            if (response == null) return;

            Kind = response.Kind;
            Id = response.Id;
            LanguageCode = response.Snippet?.Hl;
            LanguageName = response.Snippet?.Name;
        }

        public YoutubeLanguage(string languageCode, string languageName)
        {
            Kind = ResourceKind.I18nLanguage;
            Id = LanguageCode = languageCode;
            LanguageName = languageName;
        }

        public override string ToString()
        {
            return LanguageCode ?? base.ToString();
        }
    }
}