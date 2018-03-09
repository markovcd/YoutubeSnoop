using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Playlists
{
    public class Playlist : Response
    {
        /// <summary>
        /// The ID that YouTube uses to uniquely identify the playlist.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the playlist, such as its title and description.
        /// </summary>
        public Snippet Snippet { get; set; }

        /// <summary>
        /// The contentDetails object contains information about the playlist content, including the number of videos in the playlist.
        /// </summary>
        public ContentDetails ContentDetails { get; set; }

        /// <summary>
        /// The status object contains status information for the playlist.
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// The player object contains information that you would use to play the playlist in an embedded player.
        /// </summary>
        public Player Player { get; set; }

        /// <summary>
        /// The localizations object encapsulates translations of the playlist's metadata. The key is a string that contains a BCP-47 language code.
        /// </summary>
        public IDictionary<string, TitleDescription> Localizations { get; set; }
    }
}