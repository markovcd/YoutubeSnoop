using System.Collections.Generic;

namespace YoutubeSnoop.Entities.Playlists
{
    public class Playlist : Response
    {
        public string Id { get; set; }
        public Snippet Snippet { get; set; }
        public ContentDetails ContentDetails { get; set; }
        public Status Status { get; set; }
        public Player Player { get; set; }
        public IDictionary<string, TitleDescription> Localizations { get; set; }
    }
}