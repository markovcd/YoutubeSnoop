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

        public YoutubePlaylists(string channelId) 
            : this(new PlaylistApiRequestSettings { ChannelId = channelId }) { }

        public YoutubePlaylists(PlaylistApiRequestSettings settings, int resultsPerPage = 20)
        {
            Request = new ApiRequest<Playlist, PlaylistApiRequestSettings>(settings, resultsPerPage);
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