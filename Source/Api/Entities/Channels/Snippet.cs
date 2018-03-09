using System;
using System.Collections.Generic;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.Channels
{
    public class Snippet : TitleDescription
    {
        /// <summary>
        /// The channel's custom URL. The YouTube Help Center explains eligibility requirements for getting a custom URL as well as how to set up the URL.
        /// </summary>
        public string CustomUrl { get; set; }

        /// <summary>
        /// The date and time that the channel was created.
        /// </summary>
        public DateTime? PublishedAt { get; set; }

        /// <summary>
        /// A map of thumbnail images associated with the channel. For each object in the map, the key is the name of the thumbnail image, and the value is an object that contains other information about the thumbnail.
        /// </summary>
        public IDictionary<ThumbnailSize, Thumbnail> Thumbnails { get; set; }

        /// <summary>
        /// The language of the text in the channel resource's snippet.title and snippet.description properties.
        /// </summary>
        public string DefaultLanguage { get; set; }

        /// <summary>
        /// The snippet.localized object contains a localized title and description for the channel or it contains the channel's title and description in the default language for the channel's metadata.
        /// </summary>
        /// <remarks>
        /// Localized text is returned in the resource snippet if the channels.list request used the hl parameter to specify a language for which localized text should be returned, the hl parameter value identifies a YouTube application language, and localized text is available in that language.
        /// Metadata for the default language is returned if an hl parameter value is not specified or a value is specified but localized metadata is not available for the specified language.
        /// </remarks>
        public TitleDescription Localized { get; set; }

        /// <summary>
        /// The country with which the channel is associated.
        /// </summary>
        public string Country { get; set; }
    }
}