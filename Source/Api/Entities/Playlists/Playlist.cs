using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Playlists
{
    public class Playlist : Response
    {
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Snippet Snippet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ContentDetails ContentDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Player Player { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IDictionary<string, TitleDescription> Localizations { get; set; }
    }
}