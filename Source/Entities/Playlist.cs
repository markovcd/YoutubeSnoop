using System.Collections.Generic;

namespace YoutubePlaylistSnoop.Entities
{
    class Playlist
    {
        public string Kind { get; set; }
        public string Etag { get; set; }
        public string NextPageToken { get; set; }    
        public PageInfo PageInfo { get; set; }
        public IList<PlaylistItem> Items { get; set; }
    }
}
