using System.Collections;
using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Entities.Playlists;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubePlaylists : IYoutubeCollection<YoutubePlaylist>
    {
        public IApiRequest<Playlist> Request { get; }  
      
        public YoutubePlaylists(IApiRequest<Playlist> request)
        {
            Request = request;
        }

        public IEnumerator<YoutubePlaylist> GetEnumerator()
        {
            return Request.Items.Select(i => new YoutubePlaylist(i)).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}