using System;
using System.Collections.Generic;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.Playlists
{
    public class Snippet : TitleDescription
    {
        /// <summary>
        /// The date and time that the playlist was created.
        /// </summary>
        public DateTime? PublishedAt { get; set; }

        /// <summary>
        /// The ID that YouTube uses to uniquely identify the channel that published the playlist.
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// The channel title of the channel that the video belongs to.
        /// </summary>
        public string ChannelTitle { get; set; }

        /// <summary>
        /// A map of thumbnail images associated with the playlist. For each object in the map, the key is the name of the thumbnail image, and the value is an object that contains other information about the thumbnail.
        /// </summary>
        public IDictionary<ThumbnailSize, Thumbnail> Thumbnails { get; set; }

        /// <summary>
        /// Keyword tags associated with the playlist.
        /// </summary>
        public IList<string> Tags { get; set; }

        /// <summary>
        /// The language of the text in the playlist resource's snippet.title and snippet.description properties.
        /// </summary>
        public string DefaultLanguage { get; set; }

        /// <summary>
        /// The snippet.localized object contains either a localized title and description for the playlist or the title in the default language for the playlist's metadata.
        /// </summary>
        /// <remarks>
        /// Localized text is returned in the resource snippet if the playlists.list request used the hl parameter to specify a language for which localized text should be returned and localized text is available in that language.
        /// Metadata for the default language is returned if an hl parameter value is not specified or a value is specified but localized metadata is not available for the specified language.
        /// </remarks>
        public TitleDescription Localized { get; set; }
    }
}