using System.Collections;
using System.Collections.Generic;

namespace YoutubePlaylistSnoop
{
    public class YoutubePlaylist : IEnumerable<YoutubeVideoInfo>
    {
        public string PlaylistId { get; }
        public int Buffer { get; }

        public YoutubePlaylist(string playlistId, int buffer = 20)
        {
            PlaylistId = playlistId;
            Buffer = buffer;
        }

        public IEnumerator<YoutubeVideoInfo> GetEnumerator()
        {
            return new YoutubePlaylistEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
